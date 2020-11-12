using System.Collections.Generic;
using System.Threading.Tasks;
using NemzetiVirusbolt.API.Models;

namespace NemzetiVirusbolt.API.Persistence.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(int id);
    }
}
