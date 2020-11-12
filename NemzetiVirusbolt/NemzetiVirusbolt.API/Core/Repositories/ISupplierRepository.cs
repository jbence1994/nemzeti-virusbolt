using System.Collections.Generic;
using System.Threading.Tasks;
using NemzetiVirusbolt.API.Core.Models;

namespace NemzetiVirusbolt.API.Core.Repositories
{
    public interface ISupplierRepository
    {
        Task<IEnumerable<Supplier>> GetSuppliers();
        Task<Supplier> GetSupplier(int id);
    }
}
