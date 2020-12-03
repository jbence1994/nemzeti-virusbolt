using System.Collections.Generic;
using System.Threading.Tasks;
using NemzetiVirusbolt.Core.Models;

namespace NemzetiVirusbolt.Core.Repositories
{
    public interface IStockRepository
    {
        Task<IEnumerable<Stock>> GetStocks();
        Task<IEnumerable<MergedStock>> GetMergedStocks();
        Task AddStock(Stock stock);
    }
}
