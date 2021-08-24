using CalculadorDesconto.Impostos;
using CalculadorDesconto.NotasFiscais;
using CalculadorDesconto.NotasFiscais.AcoesAposGerarNotaFiscal;
using System;
using System.Collections.Generic;

namespace CalculadorDesconto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAcaoAposGerarNotaFiscal> acoesAposGerarNota = new List<IAcaoAposGerarNotaFiscal>
            {
                new EnviaPorEmail(),
                new EnviaPorSMS(),
                new SalvaNoBancoDeDados(),
                new Multiplicador(3)
            };

            var builder = new NotaFiscalBuilder(acoesAposGerarNota)
                           .ParaEmpresa("Caelum")
                           .ComCnpj("123.456.789/0001-10")
                           .Com(new ItemDaNotaBuilder().Com("item 1").Com(100.0).Constroi())
                           .Com(new ItemDaNotaBuilder().Com("item 2").Com(200.0).Constroi())
                           .Com(new ItemDaNotaBuilder().Com("item 3").Com(300.0).Constroi())
                           .ComObservacoes("entregar nf pessoalmente");


            NotaFiscal nf = builder.Constroi();
        }
    }

}
