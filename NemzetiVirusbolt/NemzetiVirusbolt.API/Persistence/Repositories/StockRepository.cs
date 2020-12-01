﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NemzetiVirusbolt.Core.Models;
using NemzetiVirusbolt.Core.Repositories;

namespace NemzetiVirusbolt.API.Persistence.Repositories
{
    public class StockRepository : IStockRepository
    {
        private readonly ApplicationDbContext _context;

        public StockRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Stock>> GetStocks()
        {
            return await _context.Stocks
                .Include(s => s.Product)
                .ToListAsync();
        }

        public Dictionary<string, int> GetMergedStocks()
        {
            var mergedStock = new Dictionary<string, int>();

            foreach (var stock in _context.Stocks.ToList())
            {
                if (mergedStock.ContainsKey(stock.Product.Name))
                    mergedStock[stock.Product.Name] += stock.Quantity;
                else
                    mergedStock.Add(stock.Product.Name, stock.Quantity);
            }

            return mergedStock;
        }

        public async Task AddStock(Stock stock)
        {
            await _context.Stocks.AddAsync(stock);
        }
    }
}