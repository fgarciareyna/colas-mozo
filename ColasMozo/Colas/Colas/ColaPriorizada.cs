using System.Collections.Generic;
using System.Linq;
using Colas.Clientes;

namespace Colas.Colas
{
    public class ColaPriorizada : ICola
    {
        public List<Cliente> Clientes = new List<Cliente>();

        public ColaPriorizada(string nombre)
        {
            Nombre = nombre;
        }

        public bool Vacia()
        {
            return Clientes.Count == 0;
        }

        public void AgregarCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
            cliente.AgregarACola(Nombre);
        }

        public Cliente ProximoCliente()
        {
            if (Vacia())
                return null;

            var prioridad = Clientes.Min(c => c.Prioridad);

            var cliente = Clientes.First(c => c.Prioridad == prioridad);
            Clientes.Remove(cliente);
            return cliente;
        }

        public int Cantidad()
        {
            return Clientes.Count;
        }

        public void Vaciar()
        {
            Clientes.Clear();
        }

        public string Nombre { get; protected set; }
    }
}
