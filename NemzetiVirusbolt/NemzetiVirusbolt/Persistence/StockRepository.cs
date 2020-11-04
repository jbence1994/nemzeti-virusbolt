using System.Collections.Generic;
using System.Linq;
using NemzetiVirusbolt.Models;
using NemzetiVirusbolt.Services;

namespace NemzetiVirusbolt.Persistence
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
