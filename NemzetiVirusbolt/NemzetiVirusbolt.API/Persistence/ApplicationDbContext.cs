using Microsoft.EntityFrameworkCore;
using NemzetiVirusbolt.API.Models;

namespace NemzetiVirusbolt.API.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
