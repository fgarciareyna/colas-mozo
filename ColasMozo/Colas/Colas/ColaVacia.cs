using Colas.Clientes;

namespace Colas.Colas
{
    public class ColaVacia : ICola
    {
        public bool Vacia()
        {
            return true;
        }

        public void AgregarCliente(Cliente cliente) {}

        public Cliente ProximoCliente()
        {
            return null;
        }

        public int Cantidad()
        {
            return 0;
        }

        public void Vaciar() {}
    }
}
