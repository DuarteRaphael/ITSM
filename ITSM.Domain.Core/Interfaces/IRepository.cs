using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSM.Domain.Core.Interfaces
{
    public interface IRepository<TEntity, TKey> : IDisposable
        where TEntity : class
    {
        Task CriarAsync(TEntity entity);
        Task AtualizarAsync(TEntity entity);
        Task ExcluirAsync(TEntity entity);
        Task<List<TEntity>> BuscarTodos(int page, int limit);
        Task<TEntity> BuscarPorId(TKey id);
    }
}
