using System.Collections.Generic;
using NemzetiVirusbolt.DesktopClient.Models;

namespace NemzetiVirusbolt.DesktopClient.Repositories
{
    public interface IStockRepository
    {
        IEnumerable<Stock> GetStocks();
    }
}
