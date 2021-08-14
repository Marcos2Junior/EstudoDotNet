using System;

namespace CalculadorDesconto.EstadosOrcamento
{
    public class Finalizado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamentos finalizados não recebem descontos extras");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamentos finalizados não pode ser aprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamentos já foi finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamentos finalizados não podem ser reprovados");
        }
    }
}
