using System.Collections.Generic;
using NemzetiVirusbolt.API.Core.Models;

namespace NemzetiVirusbolt.API.Core.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(int id);
    }
}
