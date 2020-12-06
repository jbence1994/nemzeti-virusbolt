using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NemzetiVirusbolt.Desktop.Dtos;
using Newtonsoft.Json;
using static NemzetiVirusbolt.Desktop.Services.ApiHelper;

namespace NemzetiVirusbolt.Desktop.Services.Stocks
{
    public class StockService : IStockService
    {
        private const string StocksEndPoint = "https://localhost:44399/api/stocks";
        private const string MergedStocksEndPoint = "https://localhost:44399/api/stocks/merge";
        private const string StockTotalValueEndPoint = "https://localhost:44399/api/stocks/total";

        public async Task<IEnumerable<GetStockDto>> GetStocks()
        {
            using (var response = await ApiClient.GetAsync(StocksEndPoint))
                if (response.IsSuccessStatusCode)
                {
                    var stocks = JsonConvert.DeserializeObject<List<GetStockDto>>
                        (await response.Content.ReadAsStringAsync());

                    return stocks;
                }
                else
                    throw new Exception();
        }

        public async Task<IEnumerable<GetMergedStockDto>> GetMergedStocks()
        {
            using (var response = await ApiClient.GetAsync(MergedStocksEndPoint))
                if (response.IsSuccessStatusCode)
                {
                    var mergedStocks = JsonConvert.DeserializeObject<List<GetMergedStockDto>>
                        (await response.Content.ReadAsStringAsync());

                    return mergedStocks;
                }
                else
                    throw new Exception();
        }

        public async Task AddStock(SaveStockDto stock)
        {
            await ApiClient.PostAsync
            (
                StocksEndPoint,
                new StringContent
                (
                    JsonConvert.SerializeObject(stock),
                    Encoding.UTF8,
                    MediaType
                )
            );
        }

        public async Task<StockTotalValue> GetStockTotalValue()
        {
            var totalValue = new StockTotalValue();

            using (var response = await ApiClient.GetAsync(StockTotalValueEndPoint))
                if (response.IsSuccessStatusCode)
                    totalValue =
                        JsonConvert.DeserializeObject<StockTotalValue>
                            (await response.Content.ReadAsStringAsync());

            return totalValue;
        }
    }
}
