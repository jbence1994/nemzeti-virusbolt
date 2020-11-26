using System;
using System.Collections.Generic;
using NemzetiVirusbolt.Models;

namespace NemzetiVirusbolt.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        IEnumerable<Product> IProductRepository.GetProducts()
        {
            throw new NotImplementedException();
        }

        Product IProductRepository.GetProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}
