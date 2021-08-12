using System.Collections.Generic;

namespace CalculadorDesconto
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public List<Item> Itens { get; set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
        }
    }
}