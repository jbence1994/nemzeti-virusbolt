﻿using System.Collections.Generic;
using System.Threading.Tasks;
using NemzetiVirusbolt.Desktop.Dtos;
using Newtonsoft.Json;
using static NemzetiVirusbolt.Desktop.Services.Helpers.ApiHelper;

namespace NemzetiVirusbolt.Desktop.Services.Stocks
{
    public class StockService : IStockService
    {
        private const string StocksEndPoint = "https://localhost:44399/api/stocks";
        private const string MergedStocksEndPoint = "https://localhost:44399/api/stocks/merge";

        public async Task<IEnumerable<StockDto>> GetStocks()
        {
            var stocks = new List<StockDto>();

            using var response = await ApiClient.GetAsync(StocksEndPoint);

            if (response.IsSuccessStatusCode)
                stocks = JsonConvert.DeserializeObject<List<StockDto>>(
                    await response.Content.ReadAsStringAsync());

            return stocks;
        }

        public async Task<IEnumerable<MergedStockDto>> GetMergedStocks()
        {
            var mergedStocks = new List<MergedStockDto>();

            using var response = await ApiClient.GetAsync(MergedStocksEndPoint);

            if (response.IsSuccessStatusCode)
                mergedStocks =
                    JsonConvert.DeserializeObject<List<MergedStockDto>>(await response.Content.ReadAsStringAsync());

            return mergedStocks;
        }
    }
}
