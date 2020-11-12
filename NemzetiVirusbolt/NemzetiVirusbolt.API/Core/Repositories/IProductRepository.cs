using System.Collections.Generic;
using System.Threading.Tasks;
using NemzetiVirusbolt.API.Core.Models;

namespace NemzetiVirusbolt.API.Core.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(int id);
    }
}
