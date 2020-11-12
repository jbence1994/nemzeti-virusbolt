using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using NemzetiVirusbolt.Desktop.Models;
using Newtonsoft.Json;

namespace NemzetiVirusbolt.Desktop.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly HttpClient _apiClient;

        public ProductRepository(HttpClient apiClient)
        {
            _apiClient = apiClient;

            _apiClient.DefaultRequestHeaders.Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            using (var response = await _apiClient
                .GetAsync("https://localhost:44349/api/products"))
            {
                if (!response.IsSuccessStatusCode)
                    throw new Exception("Adatok letöltése sikertelen! Ellenőrízze az internetkapcsolatot.");

                return JsonConvert
                    .DeserializeObject<List<Product>>
                        (await response.Content.ReadAsStringAsync());
            }
        }

        public async Task<Product> GetProduct(int id)
        {
            using (var response = await _apiClient
                .GetAsync("https://localhost:44349/api/products/" + id))
            {
                if (!response.IsSuccessStatusCode)
                    throw new Exception("Adatok letöltése sikertelen! Ellenőrízze az internetkapcsolatot.");

                return JsonConvert
                    .DeserializeObject<Product>(await response.Content.ReadAsStringAsync());
            }
        }
    }
}
