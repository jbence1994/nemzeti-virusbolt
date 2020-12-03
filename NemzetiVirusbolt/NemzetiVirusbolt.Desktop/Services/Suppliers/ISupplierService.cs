using System.Collections.Generic;
using System.Threading.Tasks;
using NemzetiVirusbolt.Desktop.Dtos;

namespace NemzetiVirusbolt.Desktop.Services.Suppliers
{
    public interface ISupplierService
    {
        Task<IEnumerable<GetSupplierDto>> GetSuppliers();
    }
}
