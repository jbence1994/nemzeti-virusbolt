using System.Collections.Generic;
using System.Threading.Tasks;
using NemzetiVirusbolt.Desktop.Models;

namespace NemzetiVirusbolt.Desktop.Persistence.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(int id);
    }
}
