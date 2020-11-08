using System.Collections.Generic;
using NemzetiVirusbolt.DesktopClient.Models;

namespace NemzetiVirusbolt.DesktopClient.Services
{
    public interface IStockRepository
    {
        IEnumerable<Stock> GetStocks();
    }
}
