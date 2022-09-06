using GeekBrainsCardStorageService.Repository.Data;
using GeekBrainsCardStorageService.Repository.Exceptions;
using GeekBrainsCardStorageService.Repository.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GeekBrainsCardStorageService.RepositoryDb.Repository.Implementation
{
    public class RepositoryCard : IRepositoryCard
    {
        private readonly CardStorageServiceDbContext _dbContext;
        private readonly ILogger _logger;

        public RepositoryCard(CardStorageServiceDbContext dbContext, ILogger<RepositoryCard> logger)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Card> Create(Card entity)
        {
            Card addedCard = null;

            try
            {
                addedCard = (await _dbContext.Cards.AddAsync(entity)).Entity;

                await _dbContext.SaveChangesAsync();

            }
            catch (DbUpdateException e)
            {
                throw new RepositoryFieldExeption();
            }

            return addedCard;
        }

        public async Task<Card> Update(Card entity)
        {
            Card updateCard = null;

            try
            {
                updateCard = _dbContext.Cards.Update(entity).Entity;

                await _dbContext.SaveChangesAsync();

            }
            catch (DbUpdateException e)
            {
                throw new RepositoryFieldExeption();
            }

            return updateCard;
        }

        public async Task<Card> Delete(Guid id)
        {
            Card deleteCard = null;

            try
            {
                deleteCard = _dbContext.Cards.Remove(new Card { Id = id }).Entity;

                await _dbContext.SaveChangesAsync();

            }
            catch (DbUpdateException e)
            {
                throw new RepositoryFieldExeption();
            }

            return deleteCard;
        }

        public async Task<List<Card>> GetAll() =>
            await _dbContext.Cards.ToListAsync();

        public async Task<Card> GetById(Guid id) =>
            await _dbContext.Cards.FirstOrDefaultAsync(card => card.Id == id);

        public async Task<List<Card>> GetCardsClient(int clientId) =>
            await _dbContext.Cards.Where(card => card.ClientId == clientId).ToListAsync();
    }
}
