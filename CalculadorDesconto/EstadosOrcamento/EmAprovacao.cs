namespace CalculadorDesconto.EstadosOrcamento
{
    public class EmAprovacao : EstadoDeUmOrcamento
    {
        private bool descontoAplicado = false;
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (descontoAplicado)
            {
                throw new System.Exception("Não é possível aplicar desconto duas vezes para o mesmo estado");
            }
            descontoAplicado = true;
            orcamento.Valor -= orcamento.Valor * 0.05;
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new System.Exception("Não é possivel finalizar um orcamento que esteja em aprovação");
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }
    }
}
