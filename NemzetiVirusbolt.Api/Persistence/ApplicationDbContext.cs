using Microsoft.EntityFrameworkCore;
using NemzetiVirusbolt.Api.Core.Models;
using NemzetiVirusbolt.Api.Persistence.EntityConfigurations;

namespace NemzetiVirusbolt.Api.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supply> Supplies { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MerchantEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
            modelBuilder.ApplyConfiguration(new SupplyEntityConfiguration());
        }
    }
}
