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
        public PromedioAcumulado(double valor)
        {
            Cantidad = 1;
            Promedio = valor;
        }

        public PromedioAcumulado(int cantidad, double promedio)
        {
            if (cantidad <= 0)
                throw new NotSupportedException("La cantidad de valores debe ser un número positivo");

            Cantidad = cantidad;
            Promedio = promedio;
        }

        public double CalcularSiguiente(double valor)
        {
            var total = Promedio * Cantidad + valor;

            Cantidad++;

            Promedio = total / Cantidad;

            return Promedio;
        }

        private int Cantidad { get; set; }
        public double Promedio { get; protected set; }
    }
}
