using System.Linq;
using System.Collections.Generic;

namespace FiltroBancario.Filtros
{
    public class FiltroSaldoMenorQue100Reais : Filtro
    {
        public FiltroSaldoMenorQue100Reais(Filtro outroFiltro) : base(outroFiltro)
        {
        }
        public FiltroSaldoMenorQue100Reais() : base()
        {
        }
        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            return contas.Where(x => x.Saldo < 100).ToList();
        }
    }
}
