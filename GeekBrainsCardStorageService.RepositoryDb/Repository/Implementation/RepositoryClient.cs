using GeekBrainsCardStorageService.Repository.Data;
using GeekBrainsCardStorageService.Repository.Exceptions;
using GeekBrainsCardStorageService.Repository.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GeekBrainsCardStorageService.RepositoryDb.Repository.Implementation
{
    public class RepositoryClient : IRepositoryClient
    {
        private readonly CardStorageServiceDbContext _dbContext;
        private readonly ILogger _logger;

        public RepositoryClient(CardStorageServiceDbContext dbContext, ILogger<RepositoryClient> logger)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Client> Create(Client entity)
        {
            Client addedClient = null;

            try
            {
                addedClient = (await _dbContext.Clients.AddAsync(entity)).Entity;

                await _dbContext.SaveChangesAsync();
            }
            catch(DbUpdateException e)
            {
                throw new RepositoryFieldExeption();
            }

            return addedClient;
        }

        public async Task<Client> Update(Client entity)
        {
            Client updateClient = null;

            try
            {
                updateClient = _dbContext.Clients.Update(entity).Entity;

                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new RepositoryFieldExeption();
            }

            return updateClient;
        }

        public async Task<Client> Delete(int id)
        {
            Client deleteClient = null;

            try
            {
                deleteClient = _dbContext.Clients.Remove(new Client { Id = id }).Entity;

                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new RepositoryFieldExeption();
            }

            return deleteClient;
        }

        public async Task<List<Client>> GetAll() =>
            await _dbContext.Clients.ToListAsync();

        public async Task<Client> GetById(int id) =>
            await _dbContext.Clients.FirstOrDefaultAsync(client => client.Id == id);
    }
}
