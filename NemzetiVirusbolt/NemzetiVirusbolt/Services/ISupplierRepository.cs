using System.Collections.Generic;
using NemzetiVirusbolt.Models;

namespace NemzetiVirusbolt.Services
{
    public interface ISupplierRepository
    {
        IEnumerable<Supplier> GetSuppliers();
        Supplier GetSupplier(int id);
    }
}
