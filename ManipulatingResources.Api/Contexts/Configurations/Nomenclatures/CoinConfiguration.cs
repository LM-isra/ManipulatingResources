using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ManipulatingResources.Api.Entities.Nomenclatures;

namespace ManipulatingResources.Api.Contexts.Configurations.Nomenclatures
{
    public class CoinConfiguration : IEntityTypeConfiguration<Coin>
    {
        public void Configure(EntityTypeBuilder<Coin> builder)
        {
            builder
                .HasKey(x => x.IdCoin);

            builder
                .Property(x => x.IdCoin)
                .UseIdentityColumn();

            builder
                .Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(20);

            builder
                .HasMany(x => x.AccountPayables)
                .WithOne(y => y.Coin)
                .HasForeignKey(z => z.IdCoin);

            builder
                .HasMany(x => x.AccountReceivables)
                .WithOne(y => y.Coin)
                .HasForeignKey(z => z.IdCoin);

            builder
                .ToTable("Coins");
        }

    }
}
