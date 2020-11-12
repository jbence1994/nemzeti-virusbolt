using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NemzetiVirusbolt.Desktop.Services
{
    public class ProductService
    {
        private readonly HttpClient _apiClient;
        private const string ProductsEndPoint = "https://localhost:44349/api/products";

        public ProductService()
        {
            _apiClient = new HttpClient();
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var products = new List<Product>();

            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using (var response = await _apiClient.GetAsync(ProductsEndPoint))
            {
                if (response.IsSuccessStatusCode)
                {
                    products = JsonConvert.DeserializeObject<List<Product>>(await response.Content.ReadAsStringAsync());
                }
            }

            return products;
        }
    }
}
