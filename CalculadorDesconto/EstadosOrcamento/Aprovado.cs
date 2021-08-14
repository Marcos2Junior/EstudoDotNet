namespace CalculadorDesconto.EstadosOrcamento
{
    public class Aprovado : EstadoDeUmOrcamento
    {
        private bool descontoAplicado = false;
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (descontoAplicado)
            {
                throw new System.Exception("Não é possível aplicar desconto duas vezes para o mesmo estado");
            }
            descontoAplicado = true;
            orcamento.Valor -= orcamento.Valor * 0.02;
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new System.Exception("Estado do orçamento ja está aprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new System.Exception("Não pode reprovar um pedido que ja está aprovado");
        }
    }
}
