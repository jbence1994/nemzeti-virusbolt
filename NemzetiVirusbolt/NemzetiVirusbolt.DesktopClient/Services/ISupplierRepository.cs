using System.Collections.Generic;
using NemzetiVirusbolt.DesktopClient.Models;

namespace NemzetiVirusbolt.DesktopClient.Services
{
    public interface ISupplierRepository
    {
        IEnumerable<Supplier> GetSuppliers();
        Supplier GetSupplier(int id);
    }
}
