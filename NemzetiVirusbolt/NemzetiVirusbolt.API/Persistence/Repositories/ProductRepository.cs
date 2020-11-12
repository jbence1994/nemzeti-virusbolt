using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NemzetiVirusbolt.API.Core.Models;
using NemzetiVirusbolt.API.Core.Repositories;

namespace NemzetiVirusbolt.API.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _context.Products
                .Include(p => p.Supplier)
                .ToListAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            var product = await _context.Products
                .SingleOrDefaultAsync(p => p.Id == id);

            if (product == null)
                throw new Exception("Imseretlen termék.");

            return product;
        }
    }
}
