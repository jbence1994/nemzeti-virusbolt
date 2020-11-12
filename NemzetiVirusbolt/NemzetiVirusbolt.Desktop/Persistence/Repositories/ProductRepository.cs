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
        private const string GetProductsEndPoint = "https://localhost:44349/api/products";
        private const string GetProductEndPoint = "https://localhost:44349/api/products/";

        public ProductRepository()
        {
            _apiClient = new HttpClient();

            _apiClient.DefaultRequestHeaders.Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            using (var response = await _apiClient.GetAsync(GetProductsEndPoint))
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
            using (var response = await _apiClient.GetAsync(GetProductEndPoint + id))
            {
                if (!response.IsSuccessStatusCode)
                    throw new Exception("Adatok letöltése sikertelen! Ellenőrízze az internetkapcsolatot.");

                return JsonConvert
                    .DeserializeObject<Product>(await response.Content.ReadAsStringAsync());
            }
        }
    }
}
