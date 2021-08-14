using CalculadorDesconto.EstadosOrcamento;
using System.Collections.Generic;

namespace CalculadorDesconto
{
    public class Orcamento
    {
        public EstadoDeUmOrcamento EstadoAtual { get; set; }

        public double Valor { get; set; }
        public List<Item> Itens { get; private set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
            EstadoAtual = new EmAprovacao();
        }

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }
        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }
        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }
        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}