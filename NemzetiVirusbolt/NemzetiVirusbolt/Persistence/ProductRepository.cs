using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NemzetiVirusbolt.Models;
using NemzetiVirusbolt.Services;

namespace NemzetiVirusbolt.Persistence
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
                throw new Exception("Unknown product.");

            return product;
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
        }

        public void DeleteProduct(int id)
        {
            var product = GetProduct(id);

            _context.Products.Remove(product);
        }
    }
}
