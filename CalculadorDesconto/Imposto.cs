namespace CalculadorDesconto
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; }
        public Imposto(Imposto imposto)
        {
            OutroImposto = imposto;
        }

        public Imposto()
        {
            OutroImposto = null;
        }


        public abstract double Calcula(Orcamento orcamento);

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if(OutroImposto == null) { return 0; }

            return OutroImposto.Calcula(orcamento);
        }
    }
}
