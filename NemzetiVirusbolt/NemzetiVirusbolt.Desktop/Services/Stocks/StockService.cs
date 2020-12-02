using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using NemzetiVirusbolt.Desktop.Dtos;
using Newtonsoft.Json;
using static NemzetiVirusbolt.Desktop.Services.Helpers.ApiHelper;

namespace NemzetiVirusbolt.Desktop.Services.Stocks
{
    public class StockService : IStockService
    {
        private const string StocksEndPoint = "https://localhost:44399/api/stocks";

        public async Task<IEnumerable<StockDto>> GetStocks()
        {
            var stocks = new List<StockDto>();

            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using var response = await ApiClient.GetAsync(StocksEndPoint);

            if (response.IsSuccessStatusCode)
                stocks = JsonConvert.DeserializeObject<List<StockDto>>(
                    await response.Content.ReadAsStringAsync());

            return stocks;
        }

        public Task<IEnumerable<MergedStockDto>> GetMergedStocks()
        {
            return null;
        }
    }
}
