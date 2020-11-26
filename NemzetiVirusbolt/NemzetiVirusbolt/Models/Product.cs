namespace NemzetiVirusbolt.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Unit { get; set; }
        public string Description { get; set; }
        public Supplier Supplier { get; set; }
    }
}
