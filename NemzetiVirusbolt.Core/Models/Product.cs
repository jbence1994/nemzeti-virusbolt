using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NemzetiVirusbolt.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Unit { get; set; }
        public string Description { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<Stock> Stocks { get; set; }

        public Product()
        {
            Stocks = new Collection<Stock>();
        }
    }
}
