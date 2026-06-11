using CartFlow.Dtos.CartItems;
using FluentValidation;

namespace CartFlow.Validators.CartItems;

public sealed class AddItemRequestValidator : AbstractValidator<AddItemRequest>
{
    public AddItemRequestValidator()
    {
        RuleFor(x => x.ProductId)
            .NotEmpty().WithMessage("Product ID is required.");

        RuleFor(x => x.Quantity)
            .GreaterThan(0).WithMessage("Quantity must be greater than zero.");
    }
}