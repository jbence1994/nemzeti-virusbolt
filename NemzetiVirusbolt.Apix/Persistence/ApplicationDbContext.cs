using Microsoft.EntityFrameworkCore;
using NemzetiVirusbolt.Api.Core.Models;

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
    }
}
