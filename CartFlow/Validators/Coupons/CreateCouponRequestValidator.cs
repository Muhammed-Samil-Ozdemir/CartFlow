using CartFlow.Dtos.Coupons;
using FluentValidation;

namespace CartFlow.Validators.Coupons;

public sealed class CreateCouponRequestValidator : AbstractValidator<CreateCouponRequest>
{
    public CreateCouponRequestValidator()
    {
        RuleFor(x => x.Code)
            .NotEmpty().WithMessage("Coupon code is required.")
            .MaximumLength(20).WithMessage("Coupon code must not exceed 20 characters.");

        RuleFor(x => x.DiscountAmount)
            .GreaterThanOrEqualTo(0).WithMessage("Discount amount must be greater than or equal to 0.");
        
        RuleFor(x => x.ExpiresAt)
            .GreaterThan(DateTime.Now).WithMessage("Expiration date must be in the future.");
    }
}