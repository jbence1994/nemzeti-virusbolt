using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NemzetiVirusbolt.Api.Core.Models;
using NemzetiVirusbolt.Api.Core.Repositories;

namespace NemzetiVirusbolt.Api.Persistence.Repositories
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
                .Include(product => product.Merchant)
                .ToListAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            return await _context.Products
                .Include(product => product.Merchant)
                .SingleOrDefaultAsync(product => product.Id == id);
        }

        public async Task Add(Product product)
        {
            await _context.Products.AddAsync(product);
        }
    }
}
