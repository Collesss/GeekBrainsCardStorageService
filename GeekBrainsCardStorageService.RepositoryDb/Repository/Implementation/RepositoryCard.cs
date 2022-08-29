using GeekBrainsCardStorageService.Repository.Data;
using GeekBrainsCardStorageService.Repository.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrainsCardStorageService.RepositoryDb.Repository.Implementation
{
    public class RepositoryCard : IRepositoryCard
    {
        private readonly CardStorageServiceDbContext _dbContext;

        public RepositoryCard(CardStorageServiceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Card> Create(Card entity)
        {
            //(await _dbContext.AddAsync(entity))
            throw new NotImplementedException();
        }

        public Task<Card> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Card>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Card> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Card>> GetCardsClient(int clientId)
        {
            throw new NotImplementedException();
        }

        public Task<Card> Update(Card entity)
        {
            throw new NotImplementedException();
        }
    }
}
