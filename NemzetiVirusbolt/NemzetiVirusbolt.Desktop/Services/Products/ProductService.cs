using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using NemzetiVirusbolt.Desktop.Dtos;
using Newtonsoft.Json;
using static NemzetiVirusbolt.Desktop.Services.Helpers.ApiHelper;

namespace NemzetiVirusbolt.Desktop.Services.Products
{
    public class ProductService : IProductService
    {
        private const string ProductsEndPoint = "https://localhost:44399/api/products";

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            var products = new List<ProductDto>();

            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using var response = await ApiClient.GetAsync(ProductsEndPoint);

            if (response.IsSuccessStatusCode)
                products = JsonConvert.DeserializeObject<List<ProductDto>>(
                    await response.Content.ReadAsStringAsync());

            return products;
        }
    }
}
