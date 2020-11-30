using NemzetiVirusbolt.Core.Models;

namespace NemzetiVirusbolt.Desktop.Dtos
{
    public class SupplierDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static SupplierDto ToDto(Supplier supplier)
        {
            return new SupplierDto
            {
                Id = supplier.Id,
                Name = supplier.Name
            };
        }
    }
}
