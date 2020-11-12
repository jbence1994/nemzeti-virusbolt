using System.Collections.Generic;
using NemzetiVirusbolt.Desktop.Models;

namespace NemzetiVirusbolt.Desktop.Repositories
{
    public interface IStockRepository
    {
        IEnumerable<Stock> GetStocks();
        void AddStock(Stock stock);
    }
}
