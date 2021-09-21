using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ILeilaoDao
    {
        IEnumerable<Categoria> BurcarCategorias();
        IEnumerable<Leilao> BuscarLeiloes();
        Leilao BuscarPorID(int id);
        void Incluir(Leilao leilao);
        void Alterar(Leilao leilao);
        public void Excluir(Leilao leilao);
    }
}
