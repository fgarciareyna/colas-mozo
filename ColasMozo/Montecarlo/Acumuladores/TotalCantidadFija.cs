using System.Collections.Generic;
using System.Linq;

namespace Montecarlo.Acumuladores
{
    public class TotalCantidadFija : IAcumulador
    {
        public TotalCantidadFija(int cantidad)
        {
            Cantidad = cantidad;
            Valores = new List<double>();
        }

        public double CalcularSiguiente(double valor)
        {
            if (Valores.Count == Cantidad)
                EliminarPrimero();

            Valores.Add(valor);

            var total = Valores.Sum();

            return total;
        }

        private void EliminarPrimero()
        {
            Valores.RemoveAt(0);
        }

        private int Cantidad { get; }
        private IList<double> Valores { get; }
    }
}
