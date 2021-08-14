using System.Collections.Generic;

namespace FiltroBancario
{
    public abstract class Filtro
    {
        protected Filtro OutroFiltro { get; set; }
        public Filtro()
        {
        }
        public Filtro(Filtro outroFiltro)
        {
            OutroFiltro = outroFiltro;
        }

        public abstract IList<Conta> Filtra(IList<Conta> contas);

        protected IList<Conta> Proximo(IList<Conta> contas)
        {
            if(OutroFiltro == null)
            {
                return new List<Conta>();
            }

            return OutroFiltro.Filtra(contas);
        }
    }
}
