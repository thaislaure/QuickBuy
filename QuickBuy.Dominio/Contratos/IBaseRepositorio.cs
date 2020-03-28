using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Contratos
{
    public interface IBaseRepositorio<TEntiny> : IDisposable where TEntiny : class
    {
        void Adicionar(TEntiny entidy);
        TEntiny ObterPorId(int id);
        IEnumerable<TEntiny> ObterTodos();
        void Atualizar(TEntiny entidy);
        void Remover(TEntiny entidy);

    }
}
