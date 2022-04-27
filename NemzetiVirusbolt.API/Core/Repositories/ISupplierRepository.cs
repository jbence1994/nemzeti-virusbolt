using System.Collections.Generic;
using System.Threading.Tasks;
using NemzetiVirusbolt.Api.Core.Models;

namespace NemzetiVirusbolt.Api.Core.Repositories
{
    public interface ISupplierRepository
    {
        Task<IEnumerable<Supplier>> GetSuppliers();
    }
}
