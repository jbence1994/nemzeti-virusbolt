using System.Collections.Generic;
using NemzetiVirusbolt.Desktop.Models;

namespace NemzetiVirusbolt.Desktop.Persistence.Repositories
{
    public interface IStockRepository
    {
        IEnumerable<Stock> GetStocks();
        void AddStock(Stock stock);
    }
}
