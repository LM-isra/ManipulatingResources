using Microsoft.EntityFrameworkCore;
using ManipulatingResources.Api.Entities.Data;
using ManipulatingResources.Api.Contexts.Configurations.Data;
using ManipulatingResources.Api.Contexts.Configurations.Nomenclatures;

namespace ManipulatingResources.Api.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) { }

        public DbSet<AccountPayable> AccountPayables { get; set; }
        public DbSet<AccountReceivable> AccountReceivables { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Data
            builder.ApplyConfiguration(new AccountPayableConfiguration());
            builder.ApplyConfiguration(new AccountReceivableConfiguration());
            builder.ApplyConfiguration(new ClientConfiguration());
            builder.ApplyConfiguration(new SupplierConfiguration());

            // Nomenclatures
            builder.ApplyConfiguration(new AccountTypeConfiguration());
            builder.ApplyConfiguration(new CoinConfiguration());
            builder.ApplyConfiguration(new MovementTypeConfiguration());
            builder.ApplyConfiguration(new StatusConfiguration());
        } 
    }
}