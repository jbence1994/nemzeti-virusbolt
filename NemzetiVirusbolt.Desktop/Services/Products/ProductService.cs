using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NemzetiVirusbolt.Desktop.Dtos;
using Newtonsoft.Json;
using static NemzetiVirusbolt.Desktop.Services.ApiHelper;

namespace NemzetiVirusbolt.Desktop.Services.Products
{
    public class ProductService : IProductService
    {
        private const string ProductsEndPoint = "https://localhost:44399/api/products";

        public async Task<IEnumerable<GetProductDto>> GetProducts()
        {
            using (var response = await ApiClient.GetAsync(ProductsEndPoint))
                if (response.IsSuccessStatusCode)
                {
                    var products = JsonConvert.DeserializeObject<List<GetProductDto>>
                        (await response.Content.ReadAsStringAsync());

                    return products;
                }
                else
                    throw new Exception();
        }

        public async Task<GetProductDto> AddProduct(SaveProductDto product)
        {
            var response = await ApiClient.PostAsync
            (
                ProductsEndPoint,
                new StringContent
                (
                    JsonConvert.SerializeObject(product),
                    Encoding.UTF8,
                    MediaType
                )
            );

            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<GetProductDto>
                    (await response.Content.ReadAsStringAsync());

            throw new Exception();
        }
    }
}
