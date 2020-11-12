using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NemzetiVirusbolt.API.Core.Models;
using NemzetiVirusbolt.API.Core.Repositories;

namespace NemzetiVirusbolt.API.Persistence.Repositories
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

        public async Task<Supplier> GetSupplier(int id)
        {
            var supplier = await _context.Suppliers
                .SingleOrDefaultAsync(s => s.Id == id);

            if (supplier == null)
                throw new Exception("Ismeretlen beszállító.");

            return supplier;
        }
    }
}
