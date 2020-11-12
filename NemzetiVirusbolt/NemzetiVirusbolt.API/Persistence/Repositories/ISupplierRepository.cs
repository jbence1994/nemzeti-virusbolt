using System.Collections.Generic;
using System.Threading.Tasks;
using NemzetiVirusbolt.API.Models;

namespace NemzetiVirusbolt.API.Persistence.Repositories
{
    public interface ISupplierRepository
    {
        Task<IEnumerable<Supplier>> GetSuppliers();
        Task<Supplier> GetSupplier(int id);
    }
}
