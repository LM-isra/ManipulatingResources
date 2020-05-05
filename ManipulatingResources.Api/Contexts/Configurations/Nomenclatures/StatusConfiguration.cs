using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ManipulatingResources.Api.Entities.Nomenclatures;

namespace ManipulatingResources.Api.Contexts.Configurations.Nomenclatures
{
    public class StatusConfiguration : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder
                .HasKey(x => x.IdStatus);

            builder
                .Property(x => x.IdStatus)
                .UseIdentityColumn();

            builder
                .Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(30);

            builder
                .HasMany(x => x.AccountPayables)
                .WithOne(y => y.Status)
                .HasForeignKey(z => z.IdStatus)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasMany(x => x.AccountReceivables)
                .WithOne(y => y.Status)
                .HasForeignKey(z => z.IdStatus)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasMany(x => x.Clients)
                .WithOne(y => y.Status)
                .HasForeignKey(z => z.IdStatus);

            builder
                .HasMany(x => x.Suppliers)
                .WithOne(y => y.Status)
                .HasForeignKey(z => z.IdStatus);

            builder
                .ToTable("Status");
        }
    }
}
