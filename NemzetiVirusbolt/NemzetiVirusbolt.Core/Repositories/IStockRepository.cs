using System.Collections.Generic;
using NemzetiVirusbolt.Core.Models;

namespace NemzetiVirusbolt.Core.Repositories
{
    public interface IStockRepository
    {
        IEnumerable<Stock> GetStocks();
        void AddStock(Stock stock);
    }
}
