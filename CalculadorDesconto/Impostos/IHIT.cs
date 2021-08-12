using System.Linq;

namespace CalculadorDesconto.Impostos
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Itens
                 //agrupa por nome
                 .GroupBy(x => x.Nome)
                 //verifica se existe um grupo com 2 itens
                 .Any(group => group.Count() == 2);
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.13) + 100;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.01 * orcamento.Itens.Count;
        }
    }
}
