using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Colas;
using Colas.Clientes;
using Colas.Colas;
using Colas.Servidores;
using Montecarlo.TablaDistribucion;
using NumerosAleatorios.VariablesAleatorias;

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
            ICola colaRecepcion, Servidor recepcion, ICola colaBalanza, Servidor balanza, ICola colaDarsenas,
            Servidor darsena1,
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
            //clientes
            var entreLlegadas = double.Parse(txt_llegadas.Text);
            var distribucionLlegadas = new DistribucionUniforme(entreLlegadas, entreLlegadas);

            var minInicio = (double) DateTimeConverter.EnMinutos($"{txt_apertura.Text}:00");
            var horaInicio = DateTime.Today.AddMinutes(minInicio);

            var minFin = (double) DateTimeConverter.EnMinutos($"{txt_cierre.Text}:00");
            var horaFin = DateTime.Today.AddMinutes(minFin);

            var local = new Llegada(distribucionLlegadas, horaInicio, horaFin);

            var colaMax = int.Parse(txt_cola_max.Text);

            //grupos
            var probabilidadGrupo2 = double.Parse(txt_grupos_2.Text);
            var probabilidadGrupo4 = double.Parse(txt_grupos_4.Text);

            var grupos = new DistribucionAleatoria(new List<Probabilidad>
            {
                new Probabilidad(2, probabilidadGrupo2),
                new Probabilidad(4, probabilidadGrupo4)
            });

            //menús
            var probabilidadMenu1 = double.Parse(txt_menu_1.Text);
            var probabilidadMenu2 = double.Parse(txt_menu_2.Text);

            var menus = new DistribucionAleatoria(new List<Probabilidad>
            {
                new Probabilidad(1, probabilidadMenu1),
                new Probabilidad(2, probabilidadMenu2)
            });

            var demoraMenu1 = double.Parse(txt_demora_menu_1.Text);
            var distribucionMenu1 = new DistribucionUniforme(demoraMenu1, demoraMenu1);

            var demoraMenu2 = double.Parse(txt_demora_menu_2.Text);
            var distribucionMenu2 = new DistribucionUniforme(demoraMenu2, demoraMenu2);

            //mozo
            var demoraCarta = double.Parse(txt_carta.Text);
            var distribucionCarta = new DistribucionUniforme(demoraCarta, demoraCarta);

            var demoraPedido = double.Parse(txt_pedido.Text);
            var distribucionPedido = new DistribucionUniforme(demoraPedido, demoraPedido);

            //comida
            var media = double.Parse(txt_comida_media.Text);
            var varianza = double.Parse(txt_comida_varianza.Text);

            var distribucionComida = new DistribucionNormal(media, varianza);

            //eventos
            var inicio = int.Parse(txt_desde.Text);
            var fin = int.Parse(txt_hasta.Text);

            //servidores
            var colaMesas = new ColaVacia();
            var mesa1 = new Servidor(distribucionComida, colaMesas, "Mesa 1");
            var mesa2 = new Servidor(distribucionComida, colaMesas, "Mesa 2");
            var mesa3 = new Servidor(distribucionComida, colaMesas, "Mesa 3");
            var mesa4 = new Servidor(distribucionComida, colaMesas, "Mesa 4");
            var mesa5 = new Servidor(distribucionComida, colaMesas, "Mesa 5");
            var mesa6 = new Servidor(distribucionComida, colaMesas, "Mesa 6");
            var mesa7 = new Servidor(distribucionComida, colaMesas, "Mesa 7");
            var mesa8 = new Servidor(distribucionComida, colaMesas, "Mesa 8");
            var mesa9 = new Servidor(distribucionComida, colaMesas, "Mesa 9");
            var mesa10 = new Servidor(distribucionComida, colaMesas, "Mesa 10");

            var mesas = new List<Ocupacion>
            {
                new Ocupacion(mesa1),
                new Ocupacion(mesa2),
                new Ocupacion(mesa3),
                new Ocupacion(mesa4),
                new Ocupacion(mesa5),
                new Ocupacion(mesa6),
                new Ocupacion(mesa7),
                new Ocupacion(mesa8),
                new Ocupacion(mesa9),
                new Ocupacion(mesa10)
            };

            var colaMozo = new ColaPriorizada("mozo");
            var mozo = new ServidorDoble(distribucionCarta, distribucionPedido, colaMozo, "mozo");

            var colaCocina = new ColaFifo("cocina");
            var cocina = new ServidorDoble(distribucionMenu1, distribucionMenu2, colaCocina, "cocina");

            //simulación

            var simulacion = 0;
            var numCliente = 0;
            var colaLocal = new ColaFifo("local");
            var clientes = new List<Cliente>();
            var atendidos = 0;
            var noAtendidos = 0;

            _cancelar = false;

            while (local.EstaAbierto()
                   || !mozo.EstaLibre()
                   || !cocina.EstaLibre()
                   || mesas.Any(m => !m.Mesa.EstaLibre()))
            {
                if (_cancelar) break;

                simulacion++;

                var eventos = new List<Evento>
                {
                    new Evento("Llegada", local.ProximaLlegada),
                    new Evento("Cierre", local.Cierre),
                    new Evento("Fin Mozo", mozo.ProximoFinAtencion),
                    new Evento("Fin Cocina", cocina.ProximoFinAtencion),
                    new Evento("Fin Mesa 1", mesa1.ProximoFinAtencion),
                    new Evento("Fin Mesa 2", mesa2.ProximoFinAtencion),
                    new Evento("Fin Mesa 3", mesa3.ProximoFinAtencion),
                    new Evento("Fin Mesa 4", mesa4.ProximoFinAtencion),
                    new Evento("Fin Mesa 5", mesa5.ProximoFinAtencion),
                    new Evento("Fin Mesa 6", mesa6.ProximoFinAtencion),
                    new Evento("Fin Mesa 7", mesa7.ProximoFinAtencion),
                    new Evento("Fin Mesa 8", mesa8.ProximoFinAtencion),
                    new Evento("Fin Mesa 9", mesa9.ProximoFinAtencion),
                    new Evento("Fin Mesa 10", mesa10.ProximoFinAtencion),
                };

                // ReSharper disable once PossibleInvalidOperationException
                var relojActual = eventos.Where(ev => ev.Hora.HasValue).Min(ev => ev.Hora).Value;
                var eventoActual = eventos.First(ev => ev.Hora.Equals(relojActual)).Nombre;

                switch (eventoActual)
                {
                    case "Llegada":
                        numCliente++;
                        var clienteLlegando = new Cliente($"Grupo {numCliente}", 1);
                        clienteLlegando.Llegar(relojActual);
                        var cantidadGrupo = (int)grupos.ObtenerValor();
                        if (mesas.Any(m => m.EstaLibre()))
                        {
                            mesas.First(m => m.EstaLibre()).Ocupar(clienteLlegando, cantidadGrupo);
                            mozo.LlegadaGrupo(relojActual, clienteLlegando, cantidadGrupo);
                        }
                        else if (colaLocal.Cantidad() < colaMax)
                        {
                            colaLocal.AgregarCliente(clienteLlegando);
                        }
                        else
                        {
                            clienteLlegando.Salir(relojActual);
                            noAtendidos += cantidadGrupo;
                        }
                        break;

                    case "Fin Mozo":
                        var clienteAtendido = mozo.FinAtencion();
                        var mesa = mesas.Single(m => m.Cliente.Equals(clienteAtendido));
                        if (clienteAtendido.Prioridad.Equals(1))
                        {
                            var pedido = (int)menus.ObtenerValor();
                            var cantidadPedidos = mesa.Cantidad;
                            clienteAtendido.CambiarPrioridad(pedido);
                            cocina.LlegadaGrupo(relojActual, clienteAtendido, cantidadPedidos);
                        }
                        else
                        {
                            mesa.Mesa.LlegadaCliente(relojActual, clienteAtendido);
                        }
                        break;

                    case "Fin Cocina":
                        var clienteConPedido = cocina.FinAtencion();
                        clienteConPedido.CambiarPrioridad(2);
                        mozo.LlegadaCliente(relojActual, clienteConPedido);
                        break;

                    case "Fin Mesa 1":
                        var clienteSaliendo1 = mesa1.FinAtencion();
                        clienteSaliendo1.Salir(relojActual);
                        var cantidadAtendidos1 = mesas.Single(m => m.Mesa.Equals(mesa1)).Cantidad;
                        atendidos += cantidadAtendidos1;
                        if (!colaLocal.Vacia())
                        {
                            var clienteEsperando = colaLocal.ProximoCliente();
                            var cantidadEsperando = (int)grupos.ObtenerValor();
                            mesas.First(m => m.EstaLibre()).Ocupar(clienteEsperando, cantidadEsperando);
                            mozo.LlegadaGrupo(relojActual, clienteEsperando, cantidadEsperando);
                        }
                        break;

                    case "Fin Mesa 2":
                        var clienteSaliendo2 = mesa2.FinAtencion();
                        clienteSaliendo2.Salir(relojActual);
                        var cantidadAtendidos2 = mesas.Single(m => m.Mesa.Equals(mesa2)).Cantidad;
                        atendidos += cantidadAtendidos2;
                        if (!colaLocal.Vacia())
                        {
                            var clienteEsperando = colaLocal.ProximoCliente();
                            var cantidadEsperando = (int)grupos.ObtenerValor();
                            mesas.First(m => m.EstaLibre()).Ocupar(clienteEsperando, cantidadEsperando);
                            mozo.LlegadaGrupo(relojActual, clienteEsperando, cantidadEsperando);
                        }
                        break;

                    case "Fin Mesa 3":
                        var clienteSaliendo3 = mesa3.FinAtencion();
                        clienteSaliendo3.Salir(relojActual);
                        var cantidadAtendidos3 = mesas.Single(m => m.Mesa.Equals(mesa3)).Cantidad;
                        atendidos += cantidadAtendidos3;
                        if (!colaLocal.Vacia())
                        {
                            var clienteEsperando = colaLocal.ProximoCliente();
                            var cantidadEsperando = (int)grupos.ObtenerValor();
                            mesas.First(m => m.EstaLibre()).Ocupar(clienteEsperando, cantidadEsperando);
                            mozo.LlegadaGrupo(relojActual, clienteEsperando, cantidadEsperando);
                        }
                        break;

                    case "Fin Mesa 4":
                        var clienteSaliendo4 = mesa4.FinAtencion();
                        clienteSaliendo4.Salir(relojActual);
                        var cantidadAtendidos4 = mesas.Single(m => m.Mesa.Equals(mesa4)).Cantidad;
                        atendidos += cantidadAtendidos4;
                        if (!colaLocal.Vacia())
                        {
                            var clienteEsperando = colaLocal.ProximoCliente();
                            var cantidadEsperando = (int)grupos.ObtenerValor();
                            mesas.First(m => m.EstaLibre()).Ocupar(clienteEsperando, cantidadEsperando);
                            mozo.LlegadaGrupo(relojActual, clienteEsperando, cantidadEsperando);
                        }
                        break;

                    case "Fin Mesa 5":
                        var clienteSaliendo5 = mesa5.FinAtencion();
                        clienteSaliendo5.Salir(relojActual);
                        var cantidadAtendidos5 = mesas.Single(m => m.Mesa.Equals(mesa5)).Cantidad;
                        atendidos += cantidadAtendidos5;
                        if (!colaLocal.Vacia())
                        {
                            var clienteEsperando = colaLocal.ProximoCliente();
                            var cantidadEsperando = (int)grupos.ObtenerValor();
                            mesas.First(m => m.EstaLibre()).Ocupar(clienteEsperando, cantidadEsperando);
                            mozo.LlegadaGrupo(relojActual, clienteEsperando, cantidadEsperando);
                        }
                        break;

                    case "Fin Mesa 6":
                        var clienteSaliendo6 = mesa6.FinAtencion();
                        clienteSaliendo6.Salir(relojActual);
                        var cantidadAtendidos6 = mesas.Single(m => m.Mesa.Equals(mesa6)).Cantidad;
                        atendidos += cantidadAtendidos6;
                        if (!colaLocal.Vacia())
                        {
                            var clienteEsperando = colaLocal.ProximoCliente();
                            var cantidadEsperando = (int)grupos.ObtenerValor();
                            mesas.First(m => m.EstaLibre()).Ocupar(clienteEsperando, cantidadEsperando);
                            mozo.LlegadaGrupo(relojActual, clienteEsperando, cantidadEsperando);
                        }
                        break;

                    case "Fin Mesa 7":
                        var clienteSaliendo7 = mesa7.FinAtencion();
                        clienteSaliendo7.Salir(relojActual);
                        var cantidadAtendidos7 = mesas.Single(m => m.Mesa.Equals(mesa7)).Cantidad;
                        atendidos += cantidadAtendidos7;
                        if (!colaLocal.Vacia())
                        {
                            var clienteEsperando = colaLocal.ProximoCliente();
                            var cantidadEsperando = (int)grupos.ObtenerValor();
                            mesas.First(m => m.EstaLibre()).Ocupar(clienteEsperando, cantidadEsperando);
                            mozo.LlegadaGrupo(relojActual, clienteEsperando, cantidadEsperando);
                        }
                        break;

                    case "Fin Mesa 8":
                        var clienteSaliendo8 = mesa8.FinAtencion();
                        clienteSaliendo8.Salir(relojActual);
                        var cantidadAtendidos8 = mesas.Single(m => m.Mesa.Equals(mesa8)).Cantidad;
                        atendidos += cantidadAtendidos8;
                        if (!colaLocal.Vacia())
                        {
                            var clienteEsperando = colaLocal.ProximoCliente();
                            var cantidadEsperando = (int)grupos.ObtenerValor();
                            mesas.First(m => m.EstaLibre()).Ocupar(clienteEsperando, cantidadEsperando);
                            mozo.LlegadaGrupo(relojActual, clienteEsperando, cantidadEsperando);
                        }
                        break;

                    case "Fin Mesa 9":
                        var clienteSaliendo9 = mesa9.FinAtencion();
                        clienteSaliendo9.Salir(relojActual);
                        var cantidadAtendidos9 = mesas.Single(m => m.Mesa.Equals(mesa9)).Cantidad;
                        atendidos += cantidadAtendidos9;
                        if (!colaLocal.Vacia())
                        {
                            var clienteEsperando = colaLocal.ProximoCliente();
                            var cantidadEsperando = (int)grupos.ObtenerValor();
                            mesas.First(m => m.EstaLibre()).Ocupar(clienteEsperando, cantidadEsperando);
                            mozo.LlegadaGrupo(relojActual, clienteEsperando, cantidadEsperando);
                        }
                        break;

                    case "Fin Mesa 10":
                        var clienteSaliendo10 = mesa10.FinAtencion();
                        clienteSaliendo10.Salir(relojActual);
                        var cantidadAtendidos10 = mesas.Single(m => m.Mesa.Equals(mesa10)).Cantidad;
                        atendidos += cantidadAtendidos10;
                        if (!colaLocal.Vacia())
                        {
                            var clienteEsperando = colaLocal.ProximoCliente();
                            var cantidadEsperando = (int)grupos.ObtenerValor();
                            mesas.First(m => m.EstaLibre()).Ocupar(clienteEsperando, cantidadEsperando);
                            mozo.LlegadaGrupo(relojActual, clienteEsperando, cantidadEsperando);
                        }
                        break;

                    case "Cierre":
                        local.Cerrar();
                        foreach (var cliente in colaLocal.Clientes)
                        {
                            var cantidadAfuera = (int)grupos.ObtenerValor();
                            cliente.Salir(relojActual);
                            noAtendidos += cantidadAfuera;
                        }
                        colaLocal.Vaciar();
                        break;
                }
            }
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