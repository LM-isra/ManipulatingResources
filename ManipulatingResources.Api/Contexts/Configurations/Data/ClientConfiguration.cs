using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ManipulatingResources.Api.Entities.Data;

namespace ManipulatingResources.Api.Contexts.Configurations.Data
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder
                .HasKey(x => x.IdClient);

            builder
                .Property(x => x.Address)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(x => x.AllowCredit)
                .IsRequired();

            builder
                .Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(30);

            builder
                .Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(30);

            builder
                .Property(x => x.Limit)
                .IsRequired()
                .HasColumnType("decimal");

            builder
                .Property(x => x.Phone)
                .IsRequired()
                .HasMaxLength(30);

            builder
                .HasOne(x => x.Status)
                .WithMany(y => y.Clients)
                .HasForeignKey(z => z.IdStatus);

            builder
                .HasMany(x => x.AccountReceivables)
                .WithOne(y => y.Client)
                .HasForeignKey(x => x.IdAccountReceivable);

            builder
                .ToTable("Clients");
        }
    }
}
