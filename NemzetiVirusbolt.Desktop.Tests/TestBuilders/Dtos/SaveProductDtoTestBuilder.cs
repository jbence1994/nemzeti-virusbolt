using NemzetiVirusbolt.Desktop.Dtos;

namespace NemzetiVirusbolt.Desktop.Tests.TestBuilders.Dtos
{
    public static class SaveProductDtoTestBuilder
    {
        public static SaveProductDto WithEmptyName => Build(name: "");
        public static SaveProductDto WithEmptyPrice => Build(price: "");
        public static SaveProductDto WithLettersInPrice => Build(price: "150d");
        public static SaveProductDto WithEmptyUnit => Build(unit: "");

        private static SaveProductDto Build(
            string name = "FFP3 Face Mask",
            string price = "150",
            string unit = "pieces",
            string description = "..."
        )
        {
            return new()
            {
                Name = name,
                Price = price,
                Unit = unit,
                Description = description
            };
        }
    }
}
