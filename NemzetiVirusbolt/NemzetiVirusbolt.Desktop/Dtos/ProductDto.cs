using NemzetiVirusbolt.Desktop.Models;

namespace NemzetiVirusbolt.Desktop.Dtos
{
    public class ProductDto
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Price { get; private set; }
        public string Unit { get; private set; }
        public string Description { get; private set; }
        public string SupplierName { get; private set; }

        public static ProductDto ToDto(Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price.ToString("C0"),
                Unit = product.Unit,
                Description = product.Description,
                SupplierName = product.Supplier.Name
            };
        }
    }
}
