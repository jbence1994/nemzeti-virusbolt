using System.Collections.Generic;
using System.Linq;
using NemzetiVirusbolt.Core.Models;
using NemzetiVirusbolt.Core.Repositories;

namespace NemzetiVirusbolt.Desktop.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetProduct(int id)
        {
            return _context.Products.SingleOrDefault(p => p.Id == id);
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
        }
    }
}
