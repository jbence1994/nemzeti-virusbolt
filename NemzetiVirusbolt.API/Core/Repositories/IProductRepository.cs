using System.Collections.Generic;
using System.Threading.Tasks;
using NemzetiVirusbolt.Api.Core.Models;

namespace NemzetiVirusbolt.Api.Core.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(int id);
        Task AddProduct(Product product);
    }
}
