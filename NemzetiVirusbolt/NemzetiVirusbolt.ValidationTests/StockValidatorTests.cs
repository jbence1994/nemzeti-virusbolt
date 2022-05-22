using FluentValidation.TestHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NemzetiVirusbolt.Desktop.Dtos;
using NemzetiVirusbolt.Validation;

namespace NemzetiVirusbolt.ValidationTests
{
    [TestClass]
    public class StockValidatorTests
    {
        [TestMethod]
        public void StockValidatorTest_InCaseStockQuantityIsZero_ShouldHaveErrorForStockQuantity()
        {
            // Arrange

            var stockValidator = new StockValidator();

            var stockToSave = new SaveStockDto
            {
                ProductId = 1,
                Quantity = 0
            };

            // Act

            var validationResult = stockValidator.TestValidate(stockToSave);

            // Assert

            validationResult.ShouldNotHaveValidationErrorFor(stock => stock.ProductId);

            validationResult.ShouldHaveValidationErrorFor(stock => stock.Quantity);
        }

        [TestMethod]
        public void StockValidatorTest_InCaseEveryPropertyOk_ShouldNotHaveAnyErrors()
        {
            // Arrange

            var stockValidator = new StockValidator();

            var stockToSave = new SaveStockDto
            {
                ProductId = 1,
                Quantity = 1
            };

            // Act

            var validationResult = stockValidator.TestValidate(stockToSave);

            // Assert

            validationResult.ShouldNotHaveValidationErrorFor(stock => stock.ProductId);

            validationResult.ShouldNotHaveValidationErrorFor(stock => stock.Quantity);
        }
    }
}
