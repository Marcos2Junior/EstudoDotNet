using System;

namespace CalculadorDesconto.NotasFiscais.AcoesAposGerarNotaFiscal
{
    public class Multiplicador : IAcaoAposGerarNotaFiscal
    {
        public double Fator { get; }
        public Multiplicador(double fator)
        {
            Fator = fator;
        }

        public void Executa(NotaFiscal notaFiscal)
        {
            //imprime o valor total da nota multiplicado pelo fator
            Console.WriteLine(notaFiscal.ValorBruto * Fator);
        }
    }
}
