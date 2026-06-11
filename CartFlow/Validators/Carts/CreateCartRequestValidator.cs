using CartFlow.Dtos.Carts;
using FluentValidation;

namespace CartFlow.Validators.Carts;

public sealed class CreateCartRequestValidator : AbstractValidator<CreateCartRequest>
{
    public CreateCartRequestValidator()
    {
        RuleFor(x => x.UserId)
            .NotEmpty().WithMessage("UserId is required.");
    }
}