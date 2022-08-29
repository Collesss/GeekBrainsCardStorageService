using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrainsCardStorageService.Repository.Repository.Interface.Rep
{
    internal interface IRepositoryV4<TEntity, TData, TId>
        where TEntity : class, TData, TId, new()
        where TData : class
        where TId : class
    {
        Task<List<TEntity>> GetAll();

        Task<TEntity> GetById(TId id);

        Task<TEntity> Create(TData entity);

        Task<TEntity> Update(TEntity entity);

        Task<TEntity> Delete(TId id);
    }
}
