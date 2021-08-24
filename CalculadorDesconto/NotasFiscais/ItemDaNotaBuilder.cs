namespace CalculadorDesconto.NotasFiscais
{
    public class ItemDaNotaBuilder
    {
        private string Nome;
        private double Valor;

        public Item Constroi()
        {
            return new Item(Nome, Valor);
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
