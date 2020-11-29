using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NemzetiVirusbolt.Core.Models;
using NemzetiVirusbolt.Core.Repositories;

namespace NemzetiVirusbolt.Desktop.Persistence.Repositories
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
            return _context.Stocks
                .Include(s => s.Product)
                .ToList();
        }

        public void AddStock(Stock stock)
        {
            _context.Stocks.Add(stock);
        }
    }
}
