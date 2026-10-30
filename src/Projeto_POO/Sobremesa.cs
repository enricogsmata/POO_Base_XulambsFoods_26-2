namespace XulambsFoods
{
    public enum ETipoSobremesa { Sorvete = 1, Pudim = 2, Mousse = 3 }

    public class Sobremesa : Produto
    {
        private ETipoSobremesa _tipo;

        public Sobremesa(ETipoSobremesa tipo)
        {
            _tipo = tipo;
        }

        public override double CalcularValorFinal()
        {
            return _tipo switch
            {
                ETipoSobremesa.Sorvete => 12.00,
                ETipoSobremesa.Pudim => 15.00,
                ETipoSobremesa.Mousse => 18.00,
                _ => 0.00
            };
        }

        public override string ToString() => $"Sobremesa: {_tipo} - {CalcularValorFinal():C2}";
    }
}
