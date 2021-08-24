using CalculadorDesconto.Impostos;
using CalculadorDesconto.NotasFiscais;
using System;

namespace CalculadorDesconto
{
    class Program
    {
        static void Main(string[] args)
        {
            NotaFiscal nf = new NotaFiscalBuilder()
                           .ParaEmpresa("Caelum")
                           .ComCnpj("123.456.789/0001-10")
                           .Com(new ItemDaNotaBuilder().Com("item 1").Com(100.0).Constroi())
                           .Com(new ItemDaNotaBuilder().Com("item 2").Com(200.0).Constroi())
                           .Com(new ItemDaNotaBuilder().Com("item 3").Com(300.0).Constroi())
                           .ComObservacoes("entregar nf pessoalmente")
                           .NaDataAtual()
                           .Constroi();
        }
    }

}
