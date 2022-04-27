using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NemzetiVirusbolt.Api.Core.Models;
using NemzetiVirusbolt.Api.Core.Repositories;

namespace NemzetiVirusbolt.Api.Persistence.Repositories
{
    public class SupplyRepository : ISupplyRepository
    {
        private readonly ApplicationDbContext _context;

        public SupplyRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Supply>> GetSupplies()
        {
            return await _context.Supplies
                .Include(supply => supply.Product)
                .ToListAsync();
        }

        public async Task<Supply> GetSupply(int id)
        {
            return await _context.Supplies
                .Include(supply => supply.Product)
                .SingleOrDefaultAsync(supply => supply.Id == id);
        }

        public async Task Add(Supply stock)
        {
            await _context.Supplies.AddAsync(stock);
        }

        public async Task<IEnumerable<MergedStock>> GetMergedStocks()
        {
            var mergedStock = new Dictionary<string, int>();

            foreach (var stock in await GetSupplies())
            {
                if (mergedStock.ContainsKey(stock.Product.Name))
                    mergedStock[stock.Product.Name] += stock.Quantity;
                else
                    mergedStock.Add(stock.Product.Name, stock.Quantity);
            }

            return mergedStock
                .Select(pair =>
                    new MergedStock {ProductName = pair.Key, Quantity = pair.Value});
        }

        public async Task<StockTotalValue> GetTotalStockValue()
        {
            var stocks = await GetSupplies();

            return new StockTotalValue
            {
                TotalValue =
                    stocks.Sum(s => s.Product.Price * s.Quantity)
            };
        }
    }
}
