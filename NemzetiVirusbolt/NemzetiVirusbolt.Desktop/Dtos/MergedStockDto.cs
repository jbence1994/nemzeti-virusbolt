namespace NemzetiVirusbolt.Desktop.Dtos
{
    public class MergedStockDto
    {
        public string ProductName { get; private set; }
        public int Quantity { get; private set; }

        public static MergedStockDto ToDto(string productName, int quantity)
        {
            return new MergedStockDto
            {
                ProductName = productName,
                Quantity = quantity
            };
        }
    }
}
