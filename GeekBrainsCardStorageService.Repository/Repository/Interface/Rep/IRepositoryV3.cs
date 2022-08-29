using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrainsCardStorageService.Repository.Repository.Interface.Rep
{
    internal interface IRepositoryV3<TEntity, TCreateEntity, TId>
    {
        Task<List<TEntity>> GetAll();

        Task<TEntity> GetById(TId id);

        Task<TId> Create(TCreateEntity entity);

        Task Update(TCreateEntity entity);

        Task Delete(TId id);
    }
}
