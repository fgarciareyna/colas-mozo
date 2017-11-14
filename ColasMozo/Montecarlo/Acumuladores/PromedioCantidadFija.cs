using System.Collections.Generic;
using System.Linq;

namespace Montecarlo.Acumuladores
{
    public class PromedioCantidadFija : IAcumulador
    {
        public PromedioCantidadFija(int cantidad)
        {
            Cantidad = cantidad;
            Valores = new List<decimal>();
        }

        public decimal CalcularSiguiente(decimal valor)
        {
            if (Valores.Count == Cantidad)
                EliminarPrimero();

            Valores.Add(valor);

            var promedio = Valores.Average();

            return promedio;
        }

        private void EliminarPrimero()
        {
            Valores.RemoveAt(0);
        }

        private int Cantidad { get; }
        private IList<decimal> Valores { get; }
    }
}
