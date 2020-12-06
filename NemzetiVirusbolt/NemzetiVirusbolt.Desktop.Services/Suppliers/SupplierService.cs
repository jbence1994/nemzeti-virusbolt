using System.Collections.Generic;
using System.Threading.Tasks;
using NemzetiVirusbolt.Desktop.Dtos;
using Newtonsoft.Json;
using static NemzetiVirusbolt.Desktop.Services.ApiHelper;

namespace NemzetiVirusbolt.Desktop.Services.Suppliers
{
    public class SupplierService : ISupplierService
    {
        private const string SuppliersEndPoint = "https://localhost:44399/api/suppliers";

        public async Task<IEnumerable<GetSupplierDto>> GetSuppliers()
        {
            var suppliers = new List<GetSupplierDto>();

            using (var response = await ApiClient.GetAsync(SuppliersEndPoint))
                if (response.IsSuccessStatusCode)
                    suppliers = JsonConvert.DeserializeObject<List<GetSupplierDto>>
                        (await response.Content.ReadAsStringAsync());

            return suppliers;
        }
    }
}
