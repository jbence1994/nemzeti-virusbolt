using FluentValidation.TestHelper;
using NemzetiVirusbolt.Desktop.Tests.TestBuilders.Dtos;
using NemzetiVirusbolt.Desktop.Validation;
using NUnit.Framework;

namespace NemzetiVirusbolt.Desktop.Tests.Validation
{
    [TestFixture]
    public class StockValidatorTests
    {
        private readonly StockValidator _stockValidator = new();

        [Test]
        public void StockValidatorTest_InCaseStockQuantityIsZero_ShouldHaveErrorForStockQuantity()
        {
            var stockToSave = SaveStockDtoTestBuilder.WithZeroQuantity;

            var validationResult = _stockValidator.TestValidate(stockToSave);

            validationResult.ShouldNotHaveValidationErrorFor(stock => stock.ProductId);
            validationResult.ShouldHaveValidationErrorFor(stock => stock.Quantity);
        }

        [Test]
        public void StockValidatorTest_InCaseEveryPropertyOk_ShouldNotHaveAnyErrors()
        {
            var stockToSave = SaveStockDtoTestBuilder.Default;

            var validationResult = _stockValidator.TestValidate(stockToSave);

            validationResult.ShouldNotHaveValidationErrorFor(stock => stock.ProductId);
            validationResult.ShouldNotHaveValidationErrorFor(stock => stock.Quantity);
        }
    }
}
