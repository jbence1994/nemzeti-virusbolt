using Microsoft.VisualStudio.TestTools.UnitTesting;
using NemzetiVirusbolt.Desktop.Dtos;
using NemzetiVirusbolt.Desktop.Validation;

namespace NemzetiVirusbolt.DesktopTests.Validation
{
    [TestClass]
    public class StockValidatorTests
    {
        [TestMethod]
        public void StockValidatorTest_InCaseQuantityIsZero_ShouldHaveAtLeastOneError()
        {
            // Arrange

            var stockValidator = new StockValidator();
            
            var stockToSave = new SaveStockDto
            {
                ProductId = 1,
                Quantity = 0
            };

            // Act

            var validationResult = stockValidator.Validate(stockToSave);

            // Assert

            Assert.AreEqual(1, validationResult.Errors.Count);
        }
    }
}
