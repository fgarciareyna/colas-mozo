using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Colas;
using Colas.Clientes;
using Colas.Colas;
using Colas.Servidores;

namespace TP7
{
    public partial class Tp7 : Form
    {
        private const int Decimales = 2;

        private readonly CultureInfo _culture;

        private Thread _simularThread;

        private delegate void InicioFinDelegate(bool fin);
        private delegate void ColumnasDelegate(int numCamion);
        private delegate void FilaDelegate(DateTime relojActual, string eventoActual, Llegada llegadas,
            ICola colaRecepcion, Servidor recepcion, ICola colaBalanza, Servidor balanza, ICola colaDarsenas, Servidor darsena1,
            Servidor darsena2, int atendidos, int noAtendidos, decimal permanenciaDiaria, IEnumerable<Cliente> clientes);
        private delegate void StatusDelegate(int dia, DateTime relojActual, int simulacion);
        private delegate void ResultadosDelegate(decimal promedioAtendidos, decimal promedioNoAtendidos,
            decimal promedioPermanencia);

        private bool _cancelar;

        public Tp7()
        {
            _culture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentCulture = _culture;
            Thread.CurrentThread.CurrentUICulture = _culture;

            InitializeComponent();
            FormClosing += Tp7_FormClosing;
            DoubleBuffer();
        }

        private void txt_grupos_2_TextChanged(object sender, EventArgs e)
        {
            if (!ValidarProbabilidad(txt_grupos_2)) return;

            var probabilidad2 = double.Parse(txt_grupos_2.Text);
            var probabilidad4 = 1 - probabilidad2;

            txt_grupos_4.Text = probabilidad4.ToString();
        }

        private void txt_grupos_4_TextChanged(object sender, EventArgs e)
        {
            if (!ValidarProbabilidad(txt_grupos_4)) return;

            var probabilidad4 = double.Parse(txt_grupos_4.Text);
            var probabilidad2 = 1 - probabilidad4;

            txt_grupos_2.Text = probabilidad2.ToString();
        }

        private void txt_menu_1_TextChanged(object sender, EventArgs e)
        {
            if (!ValidarProbabilidad(txt_menu_1)) return;

            var probabilidad1 = double.Parse(txt_menu_1.Text);
            var probabilidad2 = 1 - probabilidad1;

            txt_menu_2.Text = probabilidad2.ToString();
        }

        private void txt_menu_2_TextChanged(object sender, EventArgs e)
        {
            if (!ValidarProbabilidad(txt_menu_2)) return;

            var probabilidad2 = double.Parse(txt_menu_2.Text);
            var probabilidad1 = 1 - probabilidad2;

            txt_menu_1.Text = probabilidad1.ToString();
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            if (!FormularioValido()) return;

            _simularThread = new Thread(Simular)
            {
                CurrentCulture = _culture,
                CurrentUICulture = _culture
            };

            _simularThread.Start();
        }

        private void Simular()
        {
            
        }

        private void btn_detener_Click(object sender, EventArgs e)
        {
            _cancelar = true;
        }

        private bool FormularioValido()
        {
            if (!ValidarCantidades(txt_desde, txt_hasta))
                return false;

            if (!ValidarHorarios(txt_apertura, txt_cierre))
                return false;

            var parametro = "tiempo entre llegadas";
            if (!ValidarPositivo(txt_llegadas, parametro))
                return false;

            parametro = "cola máxima";
            if (!ValidarPositivo(txt_cola_max, parametro))
                return false;

            if (!ValidarProbabilidad(txt_grupos_2) ||
                !ValidarProbabilidad(txt_grupos_4) ||
                !ValidarProbabilidad(txt_menu_1) ||
                !ValidarProbabilidad(txt_menu_2))
                return false;

            parametro = "demora menú 1";
            if (!ValidarPositivo(txt_demora_menu_1, parametro))
                return false;

            parametro = "demora menú 2";
            if (!ValidarPositivo(txt_demora_menu_2, parametro))
                return false;

            parametro = "demora en tomar el pedido";
            if (!ValidarPositivo(txt_carta, parametro))
                return false;

            parametro = "demora en llevar el pedido";
            if (!ValidarPositivo(txt_pedido, parametro))
                return false;

            if (!ValidarNormal(txt_comida_media, txt_comida_varianza))
                return false;

            return true;
        }

        private static bool ValidarProbabilidad(Control txt)
        {
            const string mensaje = "La probabilidad debe ser entre 0 y 1";

            double probabilidad;

            if (!double.TryParse(txt.Text, out probabilidad)
                || probabilidad < 0 || probabilidad > 1)
            {
                MensajeError(mensaje, txt);
                return false;
            }

            return true;
        }

        private static bool ValidarCantidades(Control txtDesde, Control txtHasta)
        {
            var parametro = "evento desde";

            if (!ValidarEntero(txtDesde, parametro))
            {
                return false;
            }

            parametro = "evento hasta";

            if (!ValidarEntero(txtHasta, parametro))
            {
                return false;
            }

            const string mensaje = "El evento hasta no puede ser inferior al desde";

            var desde = int.Parse(txtDesde.Text);
            var hasta = int.Parse(txtHasta.Text);

            if (hasta < desde)
            {
                MensajeError(mensaje, txtHasta);
                return false;
            }

            return true;
        }

        private static bool ValidarHorarios(Control txtDesde, Control txtHasta)
        {
            const string pattern = @"^\d\d:\d\d$";

            var mensaje = "Ingrese un horario de apertura en formato hh:mm";

            if (string.IsNullOrEmpty(txtDesde.Text)
                || !Regex.IsMatch(txtDesde.Text, pattern))
            {
                MensajeError(mensaje, txtDesde);
                return false;
            }

            var desde = $"{txtDesde.Text}:00";
            var horaDesde = DateTimeConverter.EnMinutos(desde);

            mensaje = "Ingrese un horario de cierre en formato hh:mm";

            if (string.IsNullOrEmpty(txtHasta.Text)
                || !Regex.IsMatch(txtHasta.Text, pattern))
            {
                MensajeError(mensaje, txtHasta);
                return false;
            }

            var hasta = $"{txtHasta.Text}:00";
            var horaHasta = DateTimeConverter.EnMinutos(hasta);

            mensaje = "La hora de cierre debe ser superior a la de apertura";

            if (horaDesde >= horaHasta)
            {
                MensajeError(mensaje, txtHasta);
                return false;
            }

            return true;
        }

        private static bool ValidarEntero(Control txt, string parametro)
        {
            var mensaje = $"El valor de {parametro} debe ser un entero positivo";

            int entero;

            if (!int.TryParse(txt.Text, out entero) || entero < 0)
            {
                MensajeError(mensaje, txt);
                return false;
            }

            return false;
        }

        private static bool ValidarPositivo(Control txt, string parametro)
        {
            var mensaje = $"El valor de {parametro} debe ser positivo";

            double positivo;

            if (!double.TryParse(txt.Text, out positivo) || positivo <= 0)
            {
                MensajeError(mensaje, txt);
                return false;
            }

            return true;
        }

        private static bool ValidarNormal(Control txtMedia, Control txtVarianza)
        {
            var mensaje = "Ingrese un número válido para la media";

            if (string.IsNullOrEmpty(txtMedia.Text))
            {
                MensajeError(mensaje, txtMedia);
                return false;
            }

            double media;

            if (!double.TryParse(txtMedia.Text, out media))
            {
                MensajeError(mensaje, txtMedia);
                return false;
            }

            mensaje = "La varianza debe ser un número positivo";

            if (string.IsNullOrEmpty(txtVarianza.Text))
            {
                MensajeError(mensaje, txtVarianza);
                return false;
            }

            double varianza;

            if (!double.TryParse(txtVarianza.Text, out varianza) || varianza < 0)
            {
                MensajeError(mensaje, txtVarianza);
                return false;
            }

            return true;
        }

        private static void MensajeError(string mensaje, Control textBox)
        {
            MessageBox.Show(mensaje, @"Error");
            textBox.Focus();
        }

        public void DoubleBuffer()
        {
            // ReSharper disable once PossibleNullReferenceException
            dg_simulaciones.GetType()
                .GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)
                .SetValue(dg_simulaciones, true);
        }

        private void Tp7_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_simularThread == null
                || _simularThread.ThreadState.Equals(ThreadState.Unstarted)
                || _simularThread.ThreadState.Equals(ThreadState.Stopped))
                return;

            _cancelar = true;
            e.Cancel = true;
        }
    }
}
