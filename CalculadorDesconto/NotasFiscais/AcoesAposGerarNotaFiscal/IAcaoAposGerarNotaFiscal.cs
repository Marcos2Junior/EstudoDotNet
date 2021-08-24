namespace CalculadorDesconto.NotasFiscais.AcoesAposGerarNotaFiscal
{
    public interface IAcaoAposGerarNotaFiscal
    {
        void Executa(NotaFiscal notaFiscal);
    }
}
