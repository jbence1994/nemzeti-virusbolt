using System;
using System.Collections.Generic;
using System.Linq;
using NemzetiVirusbolt.DesktopClient.Models;
using NemzetiVirusbolt.DesktopClient.Services;

namespace NemzetiVirusbolt.DesktopClient.Persistence
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly ApplicationDbContext _context;

        public SupplierRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Supplier> GetSuppliers()
        {
            return _context.Suppliers.ToList();
        }

        public Supplier GetSupplier(int id)
        {
            var supplier = _context.Suppliers.SingleOrDefault(s => s.Id == id);

            if (supplier == null)
                throw new Exception("Unknown supplier.");

            return supplier;
        }
    }
}
