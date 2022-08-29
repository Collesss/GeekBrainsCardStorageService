namespace GeekBrainsCardStorageService.Repository.Repository.Interface
{
    public interface IRepository<TEntity, TId>
    {
        Task<List<TEntity>> GetAll();

        Task<TEntity> GetById(TId id);

        Task<TEntity> Create(TEntity entity);

        Task<TEntity> Update(TEntity entity);

        Task<TEntity> Delete(TId id);
    }
}
