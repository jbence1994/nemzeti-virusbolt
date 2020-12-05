using FluentValidation.TestHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NemzetiVirusbolt.Desktop.Dtos;
using NemzetiVirusbolt.Validation;

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
                Id = 1,
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
        public void ProductValidatorTest_InCaseProductUnitIsEmpty_ShouldHaveErrorForProductUnit()
        {
            // Arrange

            var productValidator = new ProductValidator();

            var productToSave = new SaveProductDto
            {
                Id = 1,
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
