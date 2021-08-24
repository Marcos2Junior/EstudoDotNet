using System;

namespace CalculadorDesconto.NotasFiscais.AcoesAposGerarNotaFiscal
{
    public class EnviaPorEmail : IAcaoAposGerarNotaFiscal
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Enviou email");
        }
    }
}
