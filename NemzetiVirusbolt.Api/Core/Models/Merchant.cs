using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NemzetiVirusbolt.Api.Core.Models
{
    public class Merchant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }

        public Merchant()
        {
            Products = new Collection<Product>();
        }
    }
}
