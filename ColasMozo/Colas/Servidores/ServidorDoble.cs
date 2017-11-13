using System;
using System.Diagnostics.CodeAnalysis;
using Colas.Clientes;
using Colas.Colas;
using NumerosAleatorios.VariablesAleatorias;

namespace Colas.Servidores
{
    public class ServidorDoble
    {
        public ServidorDoble(IDistribucion atencion1, IDistribucion atencion2, ICola cola, string nombre)
        {
            Distribucion1 = atencion1;
            Distribucion2 = atencion2;
            Cola = cola;
            Nombre = nombre;
            Estado = "Libre";
            CantidadAtendidos = 0;
        }

        public bool EstaLibre()
        {
            return Estado.Equals("Libre");
        }

        private void ActualizarFinAtencion(DateTime hora, int tipo)
        {
            var demora = tipo == 1 ? Distribucion1.Generar() : Distribucion2.Generar();

            ProximoFinAtencion = hora.AddMinutes(demora);
        }

        private void ActualizarFinAtencion(DateTime hora, int tipo, int cantidad)
        {
            var demora = tipo == 1 ? Distribucion1.Generar() : Distribucion2.Generar();

            ProximoFinAtencion = hora.AddMinutes(demora * cantidad);
        }

        public void LlegadaCliente(DateTime hora, Cliente cliente)
        {
            if (EstaLibre())
            {
                ClienteActual = cliente;
                Estado = $"Atendiendo a {cliente.Nombre}";
                cliente.ComenzarAtencion(hora, Nombre);
                ActualizarFinAtencion(hora, cliente.Prioridad);
            }
            else
            {
                Cola.AgregarCliente(cliente);
            }
        }

        public void LlegadaGrupo(DateTime hora, Cliente cliente, int cantidad)
        {
            if (EstaLibre())
            {
                ClienteActual = cliente;
                Estado = $"Atendiendo a {cliente.Nombre}";
                cliente.ComenzarAtencion(hora, Nombre);
                ActualizarFinAtencion(hora, cliente.Prioridad, cantidad);
            }
            else
            {
                Cola.AgregarCliente(cliente);
            }
        }

        [SuppressMessage("ReSharper", "PossibleInvalidOperationException")]
        public Cliente FinAtencion()
        {
            var cliente = ClienteActual;

            if (cliente != null)
            {
                cliente.FinalizarAtencion(ProximoFinAtencion.Value);
                CantidadAtendidos++;
            }

            if (Cola.Vacia())
            {
                Estado = "Libre";
                ClienteActual = null;
                ProximoFinAtencion = null;
            }
            else
            {
                ClienteActual = Cola.ProximoCliente();
                Estado = $"Atendiendo a {ClienteActual.Nombre}";
                ClienteActual.ComenzarAtencion(ProximoFinAtencion.Value, Nombre);
                ActualizarFinAtencion(ProximoFinAtencion.Value, ClienteActual.Prioridad);
            }


            return cliente;
        }

        public IDistribucion Distribucion1 { get; protected set; }
        public IDistribucion Distribucion2 { get; protected set; }
        public string Nombre { get; protected set; }
        public DateTime? ProximoFinAtencion { get; protected set; }
        public string Estado { get; protected set; }
        public ICola Cola { get; protected set; }
        public Cliente ClienteActual { get; protected set; }
        public int CantidadAtendidos { get; protected set; }
    }
}