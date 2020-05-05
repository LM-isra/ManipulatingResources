using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ManipulatingResources.Api.Entities.Data;

namespace ManipulatingResources.Api.Contexts.Configurations.Data
{
    public class AccountReceivableConfiguration : IEntityTypeConfiguration<AccountReceivable>
    {
        public void Configure(EntityTypeBuilder<AccountReceivable> builder)
        {
            builder
                .HasKey(x => x.IdAccountReceivable);

            builder
                .Property(x => x.Amount)
                .IsRequired()
                .HasColumnType("decimal");

            builder
                .Property(x => x.Date)
                .IsRequired();

            builder
                .Property(x => x.DatePayment);

            builder
                .Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(x => x.Invoice)
                .IsRequired()
                .HasMaxLength(20);

            builder
                .HasOne(x => x.AccountType)
                .WithMany(y => y.AccountReceivables)
                .HasForeignKey(z => z.IdAccountType);

            builder
                .HasOne(x => x.Client)
                .WithMany(y => y.AccountReceivables)
                .HasForeignKey(z => z.IdClient);

            builder
                .HasOne(x => x.Coin)
                .WithMany(y => y.AccountReceivables)
                .HasForeignKey(z => z.IdCoin);

            builder
                .HasOne(x => x.MovementType)
                .WithMany(y => y.AccountReceivables)
                .HasForeignKey(z => z.IdMovementType);

            builder
                .HasOne(x => x.Status)
                .WithMany(y => y.AccountReceivables)
                .HasForeignKey(z => z.IdStatus)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .ToTable("AccountsReceivables");
        }
    }
}
