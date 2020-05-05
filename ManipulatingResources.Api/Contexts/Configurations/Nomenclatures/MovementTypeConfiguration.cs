using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ManipulatingResources.Api.Entities.Nomenclatures;

namespace ManipulatingResources.Api.Contexts.Configurations.Nomenclatures
{
    public class MovementTypeConfiguration : IEntityTypeConfiguration<MovementType>
    {
        public void Configure(EntityTypeBuilder<MovementType> builder)
        {
            builder
                .HasKey(x => x.IdMovementType);

            builder
                .Property(x => x.IdMovementType)
                .UseIdentityColumn();

            builder
                .Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(30);

            builder
                .HasMany(x => x.AccountPayables)
                .WithOne(y => y.MovementType)
                .HasForeignKey(z => z.IdMovementType);

            builder
                .HasMany(x => x.AccountReceivables)
                .WithOne(y => y.MovementType)
                .HasForeignKey(z => z.IdMovementType);

            builder
                .ToTable("MovementsTypes");
        }
    }
}
