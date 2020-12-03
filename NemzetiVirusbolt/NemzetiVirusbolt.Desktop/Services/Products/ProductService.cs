using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NemzetiVirusbolt.Desktop.Dtos;
using NemzetiVirusbolt.Desktop.Services.Helpers;
using Newtonsoft.Json;
using static NemzetiVirusbolt.Desktop.Services.Helpers.ApiHelper;

namespace NemzetiVirusbolt.Desktop.Services.Products
{
    public class ProductService : IProductService
    {
        private const string ProductsEndPoint = "https://localhost:44399/api/products";

        public async Task<IEnumerable<GetProductDto>> GetProducts()
        {
            var products = new List<GetProductDto>();

            using var response =
                await ApiClient.GetAsync(ProductsEndPoint);

            if (response.IsSuccessStatusCode)
                products = JsonConvert
                    .DeserializeObject<List<GetProductDto>>
                        (await response.Content.ReadAsStringAsync());

            return products;
        }

        public async Task AddProduct(SaveProductDto product)
        {
            var vmi = JsonConvert.SerializeObject(product);

            await ApiClient.PostAsync(ProductsEndPoint,
                new StringContent(vmi, Encoding.UTF8, MediaType));
        }
    }
}
