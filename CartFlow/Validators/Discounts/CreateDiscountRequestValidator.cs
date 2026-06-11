using CartFlow.Dtos.Discounts;
using FluentValidation;

namespace CartFlow.Validators.Discounts;

public sealed class CreateDiscountRequestValidator : AbstractValidator<CreateDiscountRequest>
{
    public CreateDiscountRequestValidator()
    {
        RuleFor(x => x.Amount)
            .GreaterThanOrEqualTo(0).WithMessage("Amount must be greater than or equal to 0.");
    }
}