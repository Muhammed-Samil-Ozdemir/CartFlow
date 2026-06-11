using CartFlow.Dtos.Carts;
using FluentValidation;

namespace CartFlow.Validators.Carts;

public sealed class ApplyCouponRequestValidator : AbstractValidator<ApplyCouponRequest>
{
    public ApplyCouponRequestValidator()
    {
        RuleFor(x => x.CouponId)
            .NotEmpty().WithMessage("CouponId is required.");
    }
}