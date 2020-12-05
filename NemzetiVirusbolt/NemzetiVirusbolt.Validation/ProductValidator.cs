using FluentValidation;
using NemzetiVirusbolt.Desktop.Dtos;

namespace NemzetiVirusbolt.Validation
{
    public class ProductValidator : AbstractValidator<SaveProductDto>
    {
        public ProductValidator()
        {
        }
    }
}
