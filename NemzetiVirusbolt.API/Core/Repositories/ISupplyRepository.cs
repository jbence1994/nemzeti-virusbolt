using System.Collections.Generic;
using System.Threading.Tasks;
using NemzetiVirusbolt.Api.Core.Models;

namespace NemzetiVirusbolt.Api.Core.Repositories
{
    public interface ISupplyRepository
    {
        Task<IEnumerable<Supply>> GetSupplies();
        Task<Supply> GetSupply(int id);
        Task Add(Supply stock);
        Task<IEnumerable<MergedStock>> GetMergedStocks();
        Task<StockTotalValue> GetTotalStockValue();
    }
}
