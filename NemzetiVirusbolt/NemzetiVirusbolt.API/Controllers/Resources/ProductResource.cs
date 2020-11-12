namespace NemzetiVirusbolt.API.Controllers.Resources
{
    public class ProductResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Unit { get; set; }
        public string Description { get; set; }
        public SupplierResource Supplier { get; set; }
    }
}
