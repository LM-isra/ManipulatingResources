using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ManipulatingResources.Api.Entities.Data;

namespace ManipulatingResources.Api.Contexts.Configurations.Data
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder
                .HasKey(x => x.IdSupplier);

            builder
                .Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(30);

            builder
                .Property(x => x.CreditDays)
                .IsRequired();

            builder
                .HasOne(x => x.Status)
                .WithMany(y => y.Suppliers)
                .HasForeignKey(z => z.IdStatus);

            builder
                .HasMany(x => x.AccountPayables)
                .WithOne(y => y.Supplier)
                .HasForeignKey(z => z.IdAccountPayable);

            builder
                .ToTable("Suppliers");
        }
    }
}
