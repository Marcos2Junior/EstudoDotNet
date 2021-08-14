using System;

namespace CalculadorDesconto.EstadosOrcamento
{
    public class Reprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamentos reprovados não recebem descontos extras");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamentos reprovados não pode ser aprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamentos já foi reprovado");
        }
    }
}
