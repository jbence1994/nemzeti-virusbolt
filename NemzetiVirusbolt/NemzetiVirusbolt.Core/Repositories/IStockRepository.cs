using System.Collections.Generic;
using System.Threading.Tasks;
using NemzetiVirusbolt.Core.Models;

namespace NemzetiVirusbolt.Core.Repositories
{
    public interface IStockRepository
    {
        Task<IEnumerable<Stock>> GetStocks();
        Dictionary<string, int> GetMergedStocks();
        Task AddStock(Stock stock);
    }
}
