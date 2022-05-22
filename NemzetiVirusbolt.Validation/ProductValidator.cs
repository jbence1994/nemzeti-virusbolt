using FluentValidation;
using NemzetiVirusbolt.Desktop.Dtos;

namespace NemzetiVirusbolt.Validation
{
    public class ProductValidator : AbstractValidator<SaveProductDto>
    {
        public ProductValidator()
        {
            RuleFor(product => product.Name).NotEmpty();
            RuleFor(product => product.Name).Matches("^[a-zA-Z][0-9]*\\s*");
            RuleFor(product => product.Price).NotEmpty();
            RuleFor(product => product.Price).Matches("^[0-9]+$");
            RuleFor(product => product.Unit).NotEmpty();
        }
    }
}
