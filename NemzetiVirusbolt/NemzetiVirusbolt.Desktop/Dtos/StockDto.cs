using System;
using NemzetiVirusbolt.Core.Models;

namespace NemzetiVirusbolt.Desktop.Dtos
{
    public class StockDto
    {
        public int Id { get; private set; }
        public string ProductName { get; private set; }
        public int Quantity { get; private set; }
        public DateTime DateRecorded { get; private set; }

        public static StockDto ToDto(Stock stock)
        {
            return new StockDto
            {
                Id = stock.Id,
                ProductName = stock.Product.Name,
                Quantity = stock.Quantity,
                DateRecorded = stock.DateRecorded
            };
        }
    }
}
