using System;

namespace CalculadorDesconto.NotasFiscais.AcoesAposGerarNotaFiscal
{
    public class EnviaPorSMS : IAcaoAposGerarNotaFiscal
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Enviou SMS");
        }
    }
}
