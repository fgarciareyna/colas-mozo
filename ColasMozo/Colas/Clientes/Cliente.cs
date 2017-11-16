using System;

namespace Colas.Clientes
{
    public class Cliente
    {
        public Cliente(string nombre)
        {
            Nombre = nombre;
            TiempoAtencion = 0;
            TiempoEspera = 0;
            TiempoEnSistema = 0;
        }
        public Cliente(string nombre, int prioridad)
        {
            Nombre = nombre;
            Prioridad = prioridad;
            TiempoAtencion = 0;
            TiempoEspera = 0;
            TiempoEnSistema = 0;
        }

        public void Llegar(DateTime horaLlegada)
        {
            Estado = "Llegando";
            HoraLlegada = horaLlegada;
        }

        public void ComenzarAtencion(DateTime horaInicioAtencion, string servidor)
        {
            HoraInicioAtencion = horaInicioAtencion;
            Estado = $"En {servidor}";
            ActualizarTiempos(horaInicioAtencion);
        }

        public void FinalizarAtencion(DateTime horaFinAtencion)
        {
            var inicioAtencion = DateTimeConverter.EnMinutos(HoraInicioAtencion);
            var finAtencion = DateTimeConverter.EnMinutos(horaFinAtencion);

            TiempoAtencion += finAtencion - inicioAtencion;
            ActualizarTiempos(horaFinAtencion);
        }

        public void AgregarACola(string nombre)
        {
            Estado = $"En cola de {nombre}";
        }

        public void CambiarPrioridad(int prioridad)
        {
            Prioridad = prioridad;
        }

        public void Salir(DateTime horaSalida)
        {
            ActualizarTiempos(horaSalida);

            Estado = "Saliendo";
        }

        public void AgregarSubestado(string subestado)
        {
            Estado += $" ({subestado})";
        }

        private void ActualizarTiempos(DateTime horaActual)
        {
            var ingreso = DateTimeConverter.EnMinutos(HoraLlegada);
            var ahora = DateTimeConverter.EnMinutos(horaActual);

            TiempoEnSistema = ahora - ingreso;

            if (horaActual.Date > HoraLlegada.Date)
            {
                var dias = horaActual.Day - HoraLlegada.Day;
                TiempoEnSistema += dias * 24 * 60;
            }
            TiempoEspera = TiempoEnSistema - TiempoAtencion;
        }
        
        public string Nombre { get; protected set; }
        public int Prioridad { get; protected set; }
        public DateTime HoraLlegada { get; protected set; }
        public DateTime HoraInicioAtencion { get; protected set; }
        public string Estado { get; protected set; }
        public decimal TiempoEspera { get; protected set; }
        public decimal TiempoAtencion { get; protected set; }
        public decimal TiempoEnSistema { get; protected set; }
    }
}
