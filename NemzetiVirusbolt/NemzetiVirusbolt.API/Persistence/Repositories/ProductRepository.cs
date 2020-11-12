using System;
using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products
                .Include(p => p.Supplier)
                .ToList();
        }

        public Product GetProduct(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.Id == id);

            if (product == null)
                throw new Exception("Imseretlen termék.");

            return product;
        }
    }
}
