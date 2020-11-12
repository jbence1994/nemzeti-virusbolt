using System.Collections.Generic;
using System.Linq;
using NemzetiVirusbolt.DesktopClient.Models;
using NemzetiVirusbolt.DesktopClient.Repositories;

namespace NemzetiVirusbolt.DesktopClient.Persistence.Repositories
{
    public class StockRepository : IStockRepository
    {
        private readonly ApplicationDbContext _context;

        public StockRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Stock> GetStocks()
        {
            return _context.Stocks.ToList();
        }
    }
}
