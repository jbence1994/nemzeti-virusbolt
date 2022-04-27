using FluentValidation.TestHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NemzetiVirusbolt.Desktop.Tests.TestBuilders.Dtos;
using NemzetiVirusbolt.Desktop.Validation;

namespace NemzetiVirusbolt.Desktop.Tests.Validation
{
    [TestClass]
    public class StockValidatorTests
    {
        private readonly StockValidator _stockValidator = new();

        [TestMethod]
        public void StockValidatorTest_InCaseStockQuantityIsZero_ShouldHaveErrorForStockQuantity()
        {
            var stockToSave = SaveStockDtoTestBuilder.WithZeroQuantity;

            var validationResult = _stockValidator.TestValidate(stockToSave);

            validationResult.ShouldNotHaveValidationErrorFor(stock => stock.ProductId);
            validationResult.ShouldHaveValidationErrorFor(stock => stock.Quantity);
        }

        [TestMethod]
        public void StockValidatorTest_InCaseEveryPropertyOk_ShouldNotHaveAnyErrors()
        {
            var stockToSave = SaveStockDtoTestBuilder.Default;

            var validationResult = _stockValidator.TestValidate(stockToSave);

            validationResult.ShouldNotHaveValidationErrorFor(stock => stock.ProductId);
            validationResult.ShouldNotHaveValidationErrorFor(stock => stock.Quantity);
        }
    }
}
