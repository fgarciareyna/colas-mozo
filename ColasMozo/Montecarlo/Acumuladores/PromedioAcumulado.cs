using System;

namespace Montecarlo.Acumuladores
{
    public class PromedioAcumulado : IAcumulador
    {
        public PromedioAcumulado()
        {
            Cantidad = 0;
            Promedio = 0;
        }
        public PromedioAcumulado(decimal valor)
        {
            Cantidad = 1;
            Promedio = valor;
        }

        public PromedioAcumulado(int cantidad, decimal promedio)
        {
            if (cantidad <= 0)
                throw new NotSupportedException("La cantidad de valores debe ser un número positivo");

            Cantidad = cantidad;
            Promedio = promedio;
        }

        public decimal CalcularSiguiente(decimal valor)
        {
            var total = Promedio * Cantidad + valor;

            Cantidad++;

            Promedio = total / Cantidad;

            return Promedio;
        }

        private int Cantidad { get; set; }
        public decimal Promedio { get; protected set; }
    }
}
