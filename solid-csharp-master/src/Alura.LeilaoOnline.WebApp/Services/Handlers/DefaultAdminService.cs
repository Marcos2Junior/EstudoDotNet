using Alura.LeilaoOnline.WebApp.Dados;
using Alura.LeilaoOnline.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.LeilaoOnline.WebApp.Services.Handlers
{
    public class DefaultAdminService : IAdminService
    {
        readonly ILeilaoDao _daoLeilao;
        readonly ICategoriaDao _daoCategoria;

        public DefaultAdminService(ILeilaoDao dao, ICategoriaDao categoriaDao)
        {
            _daoLeilao = dao;
            _daoCategoria = categoriaDao;
        }

        public IEnumerable<Categoria> ConsultaCategorias()
        {
            return _daoCategoria.BuscaTodos();
        }

        public IEnumerable<Leilao> ConsultaLeiloes()
        {
            return _daoLeilao.BuscaTodos();
        }

        public Leilao ConsultaLeilaoPorId(int id)
        {
            return _daoLeilao.BuscarPorID(id);
        }

        public void CadastraLeilao(Leilao leilao)
        {
            _daoLeilao.Incluir(leilao);
        }

        public void ModificaLeilao(Leilao leilao)
        {
            _daoLeilao.Alterar(leilao);
        }

        public void RemoveLeilao(Leilao leilao)
        {
            if (leilao != null && leilao.Situacao != SituacaoLeilao.Pregao)
            {
                _daoLeilao.Excluir(leilao);
            }
        }

        public void FinalizaPregaoDoLeilaoComId(int id)
        {
            var leilao = _daoLeilao.BuscarPorID(id);
            if (leilao != null && leilao.Situacao == SituacaoLeilao.Pregao)
            {
                leilao.Situacao = SituacaoLeilao.Finalizado;
                leilao.Termino = DateTime.Now;
                _daoLeilao.Alterar(leilao);
            }
        }

        public void IniciaPregaoDoLeilaoComId(int id)
        {
            var leilao = _daoLeilao.BuscarPorID(id);
            if (leilao != null && leilao.Situacao == SituacaoLeilao.Rascunho)
            {
                leilao.Situacao = SituacaoLeilao.Pregao;
                leilao.Inicio = DateTime.Now;
                _daoLeilao.Alterar(leilao);
            }
        }
    }


}
