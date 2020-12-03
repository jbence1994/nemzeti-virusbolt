using System.Collections.Generic;
using System.Threading.Tasks;
using NemzetiVirusbolt.Desktop.Dtos;

namespace NemzetiVirusbolt.Desktop.Services.Products
{
    public interface IProductService
    {
        Task<IEnumerable<GetProductDto>> GetProducts();
        Task AddProduct(SaveProductDto product);
    }
}
