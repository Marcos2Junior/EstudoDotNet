using CalculadorDesconto.NotasFiscais.AcoesAposGerarNotaFiscal;
using System;
using System.Collections.Generic;

namespace CalculadorDesconto.NotasFiscais
{
    public class NotaFiscalBuilder
    {
        private string RazaoSocial;
        private string Cnpj;
        private double ValorTotal;
        private double Impostos;
        private DateTime Data = DateTime.Now;
        private string Observacoes;
        private IList<Item> todosItens = new List<Item>();

        private IList<IAcaoAposGerarNotaFiscal> AcaoAposGerarNotaFiscals = new List<IAcaoAposGerarNotaFiscal>();

        public NotaFiscalBuilder(IList<IAcaoAposGerarNotaFiscal> acaoAposGerarNotaFiscals)
        {
            AcaoAposGerarNotaFiscals = acaoAposGerarNotaFiscals;
        }

        public NotaFiscal Constroi()
        {
            var nf = new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal, Impostos, todosItens, Observacoes);

            foreach (var acao in AcaoAposGerarNotaFiscals)
            {
                acao.Executa(nf);
            }
            return nf;
        }

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder Com(Item item)
        {
            todosItens.Add(item);
            ValorTotal += item.Valor;
            Impostos += item.Valor * 0.05;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder NaData(DateTime dateTime)
        {
            Data = dateTime;
            return this;
        }
    }
}
