using System.Collections.Generic;
using NemzetiVirusbolt.API.Core.Models;

namespace NemzetiVirusbolt.API.Core.Repositories
{
    public interface ISupplierRepository
    {
        IEnumerable<Supplier> GetSuppliers();
        Supplier GetSupplier(int id);
    }
}
