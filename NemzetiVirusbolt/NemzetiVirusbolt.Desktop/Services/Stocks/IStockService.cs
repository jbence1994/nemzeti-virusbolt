using System.Collections.Generic;
using System.Threading.Tasks;
using NemzetiVirusbolt.Desktop.Dtos;

namespace NemzetiVirusbolt.Desktop.Services.Stocks
{
    public interface IStockService
    {
        Task<IEnumerable<GetStockDto>> GetStocks();
        Task<IEnumerable<GetMergedStockDto>> GetMergedStocks();
    }
}
