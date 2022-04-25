using Microsoft.EntityFrameworkCore;
using NemzetiVirusbolt.Core.Models;

namespace NemzetiVirusbolt.Api.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
