using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NemzetiVirusbolt.API.Core.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }

        public Supplier()
        {
            Products = new Collection<Product>();
        }
    }
}
