namespace CalculadorDesconto.NotasFiscais
{
    public class ItemDaNotaBuilder
    {
        private string Nome;
        private double Valor;

        public ItemDaNota Constroi()
        {
            return new ItemDaNota(Nome, Valor);
        }

        public ItemDaNotaBuilder Com(string nome)
        {
            Nome = nome;
            return this;
        }

        public ItemDaNotaBuilder Com(double valor)
        {
            Valor = valor;
            return this;
        }
    }
}
