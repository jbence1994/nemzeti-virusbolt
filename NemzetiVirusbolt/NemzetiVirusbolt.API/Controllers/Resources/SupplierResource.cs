using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NemzetiVirusbolt.API.Controllers.Resources
{
    public class SupplierResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ProductResource> Products { get; set; }

        public SupplierResource()
        {
            Products = new Collection<ProductResource>();
        }
    }
}
