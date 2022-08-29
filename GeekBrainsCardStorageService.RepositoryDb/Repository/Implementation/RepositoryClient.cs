using GeekBrainsCardStorageService.Repository.Data;
using GeekBrainsCardStorageService.Repository.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrainsCardStorageService.RepositoryDb.Repository.Implementation
{
    public class RepositoryClient : IRepositoryClient
    {
        private readonly CardStorageServiceDbContext _dbContext;

        public RepositoryClient(CardStorageServiceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Client> Create(Client entity)
        {
            throw new NotImplementedException();
        }

        public Task<Client> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Client>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Client> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Client> Update(Client entity)
        {
            throw new NotImplementedException();
        }
    }
}
