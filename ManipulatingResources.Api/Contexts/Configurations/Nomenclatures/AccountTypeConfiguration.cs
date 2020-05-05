using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ManipulatingResources.Api.Entities.Nomenclatures;

namespace ManipulatingResources.Api.Contexts.Configurations.Nomenclatures
{
    public class AccountTypeConfiguration : IEntityTypeConfiguration<AccountType>
    {
        public void Configure(EntityTypeBuilder<AccountType> builder)
        {
            builder
                .HasKey(x => x.IdAccountType);

            builder
                .Property(x => x.IdAccountType)
                .UseIdentityColumn();

            builder
                .Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(20);

            builder
                .HasMany(x => x.AccountPayables)
                .WithOne(y => y.AccountType)
                .HasForeignKey(z => z.IdAccountType);

            builder
                .HasMany(x => x.AccountReceivables)
                .WithOne(y => y.AccountType)
                .HasForeignKey(z => z.IdAccountType);

            builder
                .ToTable("AccountsTypes");
        }
    }
}
