namespace NemzetiVirusbolt.Desktop.Dtos
{
    public class SaveProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Unit { get; set; }
        public string Description { get; set; }
        public int SupplierId { get; set; }
    }
}
