using System.Collections.Generic;
using NemzetiVirusbolt.Models;

namespace NemzetiVirusbolt.Services
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        public Product GetProduct(int id);
        void AddProduct(Product product);
        void DeleteProduct(int id);
    }
}
