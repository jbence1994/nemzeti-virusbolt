using FluentValidation.TestHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NemzetiVirusbolt.Desktop.Dtos;
using NemzetiVirusbolt.Desktop.Validation;

namespace NemzetiVirusbolt.ValidationTests
{
    [TestClass]
    public class ProductValidatorTests
    {
        [TestMethod]
        public void ProductValidatorTest_InCaseProductNameIsEmpty_ShouldHaveErrorForProductName()
        {
            // Arrange

            var productValidator = new ProductValidator();

            var productToSave = new SaveProductDto
            {
                Name = "",
                Description = "...",
                Price = "3500",
                SupplierId = 1,
                Unit = "db"
            };

            // Act

            var validationResult = productValidator.TestValidate(productToSave);

            // Assert

            validationResult.ShouldHaveValidationErrorFor(product => product.Name);
        }

        [TestMethod]
        public void ProductValidatorTest_InCaseProductPriceIsEmpty_ShouldHaveErrorForProductPrice()
        {
            // Arrange

            var productValidator = new ProductValidator();

            var productToSave = new SaveProductDto
            {
                Name = "FFP3 maszk",
                Description = "...",
                Price = "",
                SupplierId = 1,
                Unit = "db"
            };

            // Act

            var validationResult = productValidator.TestValidate(productToSave);

            // Assert

            validationResult.ShouldHaveValidationErrorFor(product => product.Price);
        }

        [TestMethod]
        public void ProductValidatorTest_InCaseProductPriceContainsLetters_ShouldHaveErrorForProductPrice()
        {
            // Arrange

            var productValidator = new ProductValidator();

            var productToSave = new SaveProductDto
            {
                Name = "FFP3 maszk",
                Description = "...",
                Price = "1200d",
                SupplierId = 1,
                Unit = "db"
            };

            // Act

            var validationResult = productValidator.TestValidate(productToSave);

            // Assert

            validationResult.ShouldHaveValidationErrorFor(product => product.Price);
        }

        [TestMethod]
        public void ProductValidatorTest_InCaseProductUnitIsEmpty_ShouldHaveErrorForProductUnit()
        {
            // Arrange

            var productValidator = new ProductValidator();

            var productToSave = new SaveProductDto
            {
                Name = "FFP3 maszk",
                Description = "...",
                Price = "3500",
                SupplierId = 1,
                Unit = ""
            };

            // Act

            var validationResult = productValidator.TestValidate(productToSave);

            // Assert

            validationResult.ShouldHaveValidationErrorFor(product => product.Unit);
        }
    }
}
