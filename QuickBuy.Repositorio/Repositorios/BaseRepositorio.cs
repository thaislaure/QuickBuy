using QuickBuy.Dominio.Contratos;
using QuickBuy.Repositorio.Contexto;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntidy> : IBaseRepositorio<TEntidy> where TEntidy : class
    {

        private readonly QuickBuyContexto _quickBuyContexto;
        public BaseRepositorio(QuickBuyContexto quickBuyContexto)
        {
            _quickBuyContexto = quickBuyContexto;
        }

        public void Adicionar(TEntidy entidy)
        {
            _quickBuyContexto.Set<TEntidy>().Add(entidy);
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
            return _quickBuyContexto.Set<TEntidy>().ToList();
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
