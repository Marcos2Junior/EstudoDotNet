using System;

namespace CalculadorDesconto.NotasFiscais.AcoesAposGerarNotaFiscal
{
    public class SalvaNoBancoDeDados : IAcaoAposGerarNotaFiscal
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Gravou no banco");
        }
    }
}
