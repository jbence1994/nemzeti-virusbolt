using System.Collections.Generic;
using System.Threading.Tasks;
using NemzetiVirusbolt.Api.Core.Models;

namespace NemzetiVirusbolt.Api.Core.Repositories
{
    public interface IStockRepository
    {
        Task<IEnumerable<Stock>> GetStocks();
        Task<IEnumerable<MergedStock>> GetMergedStocks();
        Task<Stock> GetStock(int id);
        Task AddStock(Stock stock);
        Task<StockTotalValue> GetTotalStockValue();
    }
}
