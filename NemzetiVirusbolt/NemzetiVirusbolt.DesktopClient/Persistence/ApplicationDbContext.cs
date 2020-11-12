using Microsoft.EntityFrameworkCore;
using NemzetiVirusbolt.DesktopClient.Models;

namespace NemzetiVirusbolt.DesktopClient.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
