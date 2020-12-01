using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using NemzetiVirusbolt.Desktop.Dtos;
using Newtonsoft.Json;

namespace NemzetiVirusbolt.Desktop.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _apiClient;
        private const string ProductsEndPoint = "https://localhost:44399/api/products";

        public ProductService()
        {
            _apiClient = new HttpClient();
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            var products = new List<ProductDto>();

            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using var response = await _apiClient.GetAsync(ProductsEndPoint);

            if (response.IsSuccessStatusCode)
                products = JsonConvert.DeserializeObject<List<ProductDto>>(
                    await response.Content.ReadAsStringAsync());

            return products;
        }
    }
}
