using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NemzetiVirusbolt.Api.Core.Models;
using NemzetiVirusbolt.Api.Core.Repositories;

namespace NemzetiVirusbolt.Api.Persistence.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly ApplicationDbContext _context;

        public SupplierRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Supplier>> GetSuppliers()
        {
            return await _context.Suppliers.ToListAsync();
        }
    }
}
