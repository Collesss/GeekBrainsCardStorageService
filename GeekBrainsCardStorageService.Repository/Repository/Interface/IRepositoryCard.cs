using GeekBrainsCardStorageService.Repository.Data;

namespace GeekBrainsCardStorageService.Repository.Repository.Interface
{
    public interface IRepositoryCard : IRepository<Card, Guid>
    {
        Task<List<Card>> GetCardsClient(int clientId);
    }
}
