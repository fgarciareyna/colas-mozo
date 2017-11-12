namespace Montecarlo.Acumuladores
{
    public class TotalAcumulado : IAcumulador
    {
        public TotalAcumulado()
        {
            Total = 0;
        }
        public TotalAcumulado(double valor)
        {
            Total = valor;
        }

        public double CalcularSiguiente(double valor)
        {
            Total += valor;

            return Total;
        }
        public double Total { get; protected set; }
    }
}
