using System.Collections.Generic;
using System.Threading.Tasks;
using NemzetiVirusbolt.Desktop.Dtos;

namespace NemzetiVirusbolt.Desktop.Services.Stocks
{
    public interface IStockService
    {
        Task<IEnumerable<StockDto>> GetStocks();
        Task<IEnumerable<MergedStockDto>> GetMergedStocks();
    }
}
