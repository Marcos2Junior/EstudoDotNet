using System;
using System.Linq;
using System.Collections.Generic;

namespace FiltroBancario.Filtros
{
    public class FiltroDataAberturaMesmoMes : Filtro
    {
        public FiltroDataAberturaMesmoMes(Filtro outroFiltro) : base(outroFiltro)
        {
        }
        public FiltroDataAberturaMesmoMes() : base()
        {
        }
        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            return contas.Where(x => x.DataAbertura.Month == DateTime.Now.Month && x.DataAbertura.Year == DateTime.Now.Year).ToList();
        }
     }
}
