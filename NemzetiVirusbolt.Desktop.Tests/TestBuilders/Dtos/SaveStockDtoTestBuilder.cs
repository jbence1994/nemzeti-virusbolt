using NemzetiVirusbolt.Desktop.Dtos;

namespace NemzetiVirusbolt.Desktop.Tests.TestBuilders.Dtos
{
    public static class SaveStockDtoTestBuilder
    {
        public static SaveStockDto Default => Build();
        public static SaveStockDto WithZeroQuantity => Build(quantity: 0);

        private static SaveStockDto Build(
            int productId = 1,
            int quantity = 1
        )
        {
            return new()
            {
                ProductId = productId,
                Quantity = quantity
            };
        }
    }
}
