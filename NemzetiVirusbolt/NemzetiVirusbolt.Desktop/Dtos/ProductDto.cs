using NemzetiVirusbolt.Desktop.Models;

namespace NemzetiVirusbolt.Desktop.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Unit { get; set; }
        public string Description { get; set; }
        public string SupplierName { get; set; }

        public static ProductDto ToDto(Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Unit = product.Unit,
                Description = product.Description,
                SupplierName = product.Supplier.Name
            };
        }
    }
}
