using GeekBrainsCardStorageService.Repository.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GeekBrainsCardStorageService.RepositoryDb.EntityConfigurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(client => client.Id);

            builder.Property(client => client.FirstName)
                .IsRequired()
                .HasMaxLength(55);

            builder.Property(client => client.Surname)
                .IsRequired()
                .HasMaxLength(55);

            builder.Property(client => client.Patronymic)
                .IsRequired()
                .HasMaxLength(55);

            builder.HasIndex(client => new { client.FirstName, client.Surname, client.Patronymic });
        }
    }
}
