using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using NemzetiVirusbolt.Desktop.Dtos;
using Newtonsoft.Json;

namespace NemzetiVirusbolt.Desktop.Services.Suppliers
{
    public class SupplierService : ISupplierService
    {
        private readonly HttpClient _apiClient;
        private const string SuppliersEndPoint = "https://localhost:44399/api/suppliers";

        public SupplierService()
        {
            _apiClient = new HttpClient();
        }

        public async Task<IEnumerable<SupplierDto>> GetSuppliers()
        {
            var suppliers = new List<SupplierDto>();

            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using var response = await _apiClient.GetAsync(SuppliersEndPoint);

            if (response.IsSuccessStatusCode)
                suppliers = JsonConvert.DeserializeObject<List<SupplierDto>>(
                    await response.Content.ReadAsStringAsync());

            return suppliers;
        }
    }
}
