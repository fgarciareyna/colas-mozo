using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
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
