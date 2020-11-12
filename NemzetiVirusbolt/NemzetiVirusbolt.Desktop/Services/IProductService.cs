using System.Collections.Generic;
using System.Threading.Tasks;

namespace NemzetiVirusbolt.Desktop.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(int id);
    }
}
