using System.Collections.Generic;
using NemzetiVirusbolt.Models;

namespace NemzetiVirusbolt.Persistence.Repositories
{
    public interface IStockRepository
    {
        IEnumerable<Stock> GetStocks();
        void AddStock(Stock stock);
    }
}
