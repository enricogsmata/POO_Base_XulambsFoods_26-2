namespace XulambsFoods
{
    public enum ETipoBebida { Agua = 1, Refrigerante = 2, Suco = 3 }

    public class Bebida : Produto
    {
        private ETipoBebida _tipo;

        public Bebida(ETipoBebida tipo)
        {
            _tipo = tipo;
        }

        public override double CalcularValorFinal()
        {
            return _tipo switch
            {
                ETipoBebida.Agua => 5.00,
                ETipoBebida.Refrigerante => 8.00,
                ETipoBebida.Suco => 10.00,
                _ => 0.00
            };
        }

        public override string ToString() => $"Bebida: {_tipo} - {CalcularValorFinal():C2}";
    }
}
