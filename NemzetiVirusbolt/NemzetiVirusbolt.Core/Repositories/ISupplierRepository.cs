using System.Collections.Generic;
using NemzetiVirusbolt.Core.Models;

namespace NemzetiVirusbolt.Core.Repositories
{
    public interface ISupplierRepository
    {
        IEnumerable<Supplier> GetSuppliers();
    }
}
