using System.Linq;
using System.Collections.Generic;

namespace FiltroBancario.Filtros
{
    public class FiltroSaldoMaiorQue500MilReais : Filtro
    {
        public FiltroSaldoMaiorQue500MilReais(Filtro outroFiltro) : base(outroFiltro)
        {
        }
        public FiltroSaldoMaiorQue500MilReais() : base ()
        {
        }
        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            return contas.Where(x => x.Saldo > 500.000).ToList();
        }
    }
}
