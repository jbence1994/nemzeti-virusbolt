using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using NemzetiVirusbolt.Desktop.Dtos;
using Newtonsoft.Json;
using static NemzetiVirusbolt.Desktop.Services.Helpers.ApiHelper;

namespace NemzetiVirusbolt.Desktop.Services.Suppliers
{
    public class SupplierService : ISupplierService
    {
        private const string SuppliersEndPoint = "https://localhost:44399/api/suppliers";

        public async Task<IEnumerable<SupplierDto>> GetSuppliers()
        {
            var suppliers = new List<SupplierDto>();

            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using var response = await ApiClient.GetAsync(SuppliersEndPoint);

            if (response.IsSuccessStatusCode)
                suppliers = JsonConvert.DeserializeObject<List<SupplierDto>>(
                    await response.Content.ReadAsStringAsync());

            return suppliers;
        }
    }
}
