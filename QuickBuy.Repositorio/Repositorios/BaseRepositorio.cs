using QuickBuy.Dominio.Contratos;
using System.Collections.Generic;

namespace QuickBuy.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntidy> : IBaseRepositorio<TEntidy> where TEntidy : class
    {

        public BaseRepositorio()
        {

        }

        public void Adicionar(TEntidy entidy)
        {
            throw new System.NotImplementedException();
        }

        public void Atualizar(TEntidy entidy)
        {
            throw new System.NotImplementedException();
        }

        public TEntidy ObterPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TEntidy> ObterTodos()
        {
            throw new System.NotImplementedException();
        }

        public void Remover(TEntidy entidy)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
