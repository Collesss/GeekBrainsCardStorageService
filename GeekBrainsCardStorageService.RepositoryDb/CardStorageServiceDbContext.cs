using GeekBrainsCardStorageService.Repository.Data;
using GeekBrainsCardStorageService.RepositoryDb.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace GeekBrainsCardStorageService.RepositoryDb
{
    public class CardStorageServiceDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Card> Cards { get; set; }

        public CardStorageServiceDbContext(DbContextOptions<CardStorageServiceDbContext> contextOptions) : base(contextOptions) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CardConfiguration());
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
        }
    }
}
