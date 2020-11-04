using System.Collections.Generic;
using NemzetiVirusbolt.Models;

namespace NemzetiVirusbolt.Services
{
    public interface IStockRepository
    {
        IEnumerable<Stock> GetStocks();
    }
}
