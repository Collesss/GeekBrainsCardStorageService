using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrainsCardStorageService.Repository.Repository.Interface.Rep
{
    internal interface IRepositoryV2<TEntity, TCreateEntity, TId>
    {
        Task<List<TEntity>> GetAll();

        Task<TEntity> GetById(TId id);

        Task<TEntity> Create(TEntity entity);

        Task<TEntity> Update(TCreateEntity entity);

        Task<TEntity> Delete(TId id);
    }
}
