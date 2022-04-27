using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NemzetiVirusbolt.Api.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Unit { get; set; }
        public string Description { get; set; }
        public int MerchantId { get; set; }
        public Merchant Merchant { get; set; }
        public ICollection<Supply> Supplies { get; set; }

        public Product()
        {
            Supplies = new Collection<Supply>();
        }
    }
}
