using System.Collections.Generic;

namespace NemzetiVirusbolt.Core.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Product> Products { get; set; }

        public Supplier()
        {
            Products = new List<Product>();
        }
    }
}
