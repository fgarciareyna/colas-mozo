namespace Montecarlo.Acumuladores
{
    public class TotalAcumulado : IAcumulador
    {
        public TotalAcumulado()
        {
            Total = 0;
        }
        public TotalAcumulado(decimal valor)
        {
            Total = valor;
        }

        public decimal CalcularSiguiente(decimal valor)
        {
            Total += valor;

            return Total;
        }
        public decimal Total { get; protected set; }
    }
}
