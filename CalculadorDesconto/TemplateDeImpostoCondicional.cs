namespace CalculadorDesconto
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        public TemplateDeImpostoCondicional(Imposto outroImposto) : base(outroImposto)
        {
        }
        public TemplateDeImpostoCondicional() : base()
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            double result;
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                result = MaximaTaxacao(orcamento);
            }
            else
            {
                result = MinimaTaxacao(orcamento);
            }

            return result + CalculoDoOutroImposto(orcamento);
        }

        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
    }
}
