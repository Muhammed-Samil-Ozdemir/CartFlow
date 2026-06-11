using CartFlow.Dtos.CartItems;
using FluentValidation;

namespace CartFlow.Validators.CartItems;

public sealed class UpdateQuantityRequestValidator : AbstractValidator<UpdateQuantityRequest>
{
    public UpdateQuantityRequestValidator()
    {
        RuleFor(x => x.Quantity)
            .GreaterThanOrEqualTo(0).WithMessage("Quantity must be greater than or equal to zero.");
    }
}