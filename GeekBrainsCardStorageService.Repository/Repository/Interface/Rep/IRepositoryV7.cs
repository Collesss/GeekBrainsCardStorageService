﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrainsCardStorageService.Repository.Repository.Interface.Rep
{
    internal interface IRepositoryV7<TEntity, TId>
    {
        Task<List<TEntity>> GetAll();

        Task<TEntity> GetById(TId id);

        Task<TEntity> Create(TEntity entity);

        Task<TEntity> Update(TEntity entity);

        Task<TEntity> Delete(TEntity entity);
    }
}
