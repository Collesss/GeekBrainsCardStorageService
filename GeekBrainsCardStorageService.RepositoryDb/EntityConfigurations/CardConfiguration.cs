using GeekBrainsCardStorageService.Repository.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GeekBrainsCardStorageService.RepositoryDb.EntityConfigurations
{
    public class CardConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasKey(card => card.Id);

            builder.HasAlternateKey(card => card.CardNumber);
            builder.Property(card => card.CardNumber)
                .HasMaxLength(20);

            builder.Property(card => card.Name)
                .HasMaxLength(55);
            builder.HasIndex(card => card.Name);

            builder.Property(card => card.CVV2)
                .HasMaxLength(5);

            builder.HasIndex(card => card.ExpDate);

            builder.HasOne<Client>()
                .WithMany()
                .HasForeignKey(card => card.ClientId)
                .HasPrincipalKey(client => client.Id);
        }
    }
}
