using QuickBuy.Dominio.Contratos;
using QuickBuy.Repositorio.Contexto;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntidy> : IBaseRepositorio<TEntidy> where TEntidy : class
    {

        protected readonly QuickBuyContexto QuickBuyContexto;
        public BaseRepositorio(QuickBuyContexto quickBuyContexto)
        {
            QuickBuyContexto = quickBuyContexto;
        }

        public void Adicionar(TEntidy entidy)
        {
            QuickBuyContexto.Set<TEntidy>().Add(entidy);
            QuickBuyContexto.SaveChanges();
        }

        public void Atualizar(TEntidy entidy)
        {
            QuickBuyContexto.Set<TEntidy>().Update(entidy);
            QuickBuyContexto.SaveChanges();
        }

        public TEntidy ObterPorId(int id)
        {
            return QuickBuyContexto.Set<TEntidy>().Find(id);
        }

        public IEnumerable<TEntidy> ObterTodos()
        {
            return QuickBuyContexto.Set<TEntidy>().ToList();
        }

        public void Remover(TEntidy entidy)
        {
            QuickBuyContexto.Remove(entidy);
            QuickBuyContexto.SaveChanges();
        }

        public void Dispose()
        {
            QuickBuyContexto.Dispose();
        }
    }
}
