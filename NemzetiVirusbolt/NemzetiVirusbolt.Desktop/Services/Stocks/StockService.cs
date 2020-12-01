using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using NemzetiVirusbolt.Desktop.Dtos;
using Newtonsoft.Json;

namespace NemzetiVirusbolt.Desktop.Services.Stocks
{
    public class StockService : IStockService
    {
        private readonly HttpClient _apiClient;
        private const string StocksEndPoint = "https://localhost:44399/api/stocks";

        public StockService()
        {
            _apiClient = new HttpClient();
        }

        public async Task<IEnumerable<StockDto>> GetStocks()
        {
            var stocks = new List<StockDto>();

            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using var response = await _apiClient.GetAsync(StocksEndPoint);

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
