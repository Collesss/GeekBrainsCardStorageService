using GeekBrainsCardStorageService.Repository.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrainsCardStorageService.RepositoryDb.EntityConfigurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(client => client.Id);

            builder.Property(client => client.FirstName)
                .HasMaxLength(55);

            builder.Property(client => client.Surname)
                .HasMaxLength(55);

            builder.Property(client => client.Patronymic)
                .HasMaxLength(55);

            builder.HasIndex(client => new { client.FirstName, client.Surname, client.Patronymic });
        }
    }
}
