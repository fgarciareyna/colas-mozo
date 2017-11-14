using System;
using Colas.Clientes;
using Colas.Servidores;

namespace TP7
{
    public class Ocupacion
    {
        public Ocupacion(Servidor mesa)
        {
            Mesa = mesa;
            Cantidad = 0;
        }

        public bool EstaLibre()
        {
            return Cliente == null;
        }

        public void Ocupar(Cliente cliente, int cantidad)
        {
            if (!EstaLibre())
                throw new NotSupportedException("La mesa está ocupada");

            Cliente = cliente;
            Cantidad = cantidad;
        }

        public Cliente Liberar()
        {
            if (EstaLibre())
                throw new NotSupportedException("La mesa está libre");

            var clienteActual = Cliente;
            Cliente = null;
            Cantidad = 0;
            return clienteActual;
        }

        public Servidor Mesa { get; protected set; }
        public Cliente Cliente { get; protected set; }
        public int Cantidad { get; protected set; }
    }
}
