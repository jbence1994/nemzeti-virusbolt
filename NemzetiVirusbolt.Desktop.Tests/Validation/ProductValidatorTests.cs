using FluentValidation.TestHelper;
using NemzetiVirusbolt.Desktop.Tests.TestBuilders.Dtos;
using NemzetiVirusbolt.Desktop.Validation;
using NUnit.Framework;

namespace NemzetiVirusbolt.Desktop.Tests.Validation
{
    [TestFixture]
    public class ProductValidatorTests
    {
        private readonly ProductValidator _productValidator = new();

        [Test]
        public void ProductValidatorTest_InCaseProductNameIsEmpty_ShouldHaveErrorForProductName()
        {
            var productToSave = SaveProductDtoTestBuilder.WithEmptyName;

            var validationResult = _productValidator.TestValidate(productToSave);

            validationResult.ShouldHaveValidationErrorFor(product => product.Name);
        }

        [Test]
        public void ProductValidatorTest_InCaseProductPriceIsEmpty_ShouldHaveErrorForProductPrice()
        {
            var productToSave = SaveProductDtoTestBuilder.WithEmptyPrice;

            var validationResult = _productValidator.TestValidate(productToSave);

            validationResult.ShouldHaveValidationErrorFor(product => product.Price);
        }

        [Test]
        public void ProductValidatorTest_InCaseProductPriceContainsLetters_ShouldHaveErrorForProductPrice()
        {
            var productToSave = SaveProductDtoTestBuilder.WithLettersInPrice;

            var validationResult = _productValidator.TestValidate(productToSave);

            validationResult.ShouldHaveValidationErrorFor(product => product.Price);
        }

        [Test]
        public void ProductValidatorTest_InCaseProductUnitIsEmpty_ShouldHaveErrorForProductUnit()
        {
            var productToSave = SaveProductDtoTestBuilder.WithEmptyUnit;

            var validationResult = _productValidator.TestValidate(productToSave);

            validationResult.ShouldHaveValidationErrorFor(product => product.Unit);
        }
    }
}
