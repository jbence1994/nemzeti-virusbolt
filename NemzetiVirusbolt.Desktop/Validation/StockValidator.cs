using FluentValidation;
using NemzetiVirusbolt.Desktop.Dtos;

namespace NemzetiVirusbolt.Desktop.Validation
{
    public class StockValidator : AbstractValidator<SaveStockDto>
    {
        public StockValidator()
        {
            RuleFor(stock => stock.Quantity)
                .GreaterThan(0);
        }
    }
}
