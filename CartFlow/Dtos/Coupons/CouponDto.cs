namespace CartFlow.Dtos.Coupons;

public sealed record CouponDto(
    Guid Id,
    string Code,
    decimal DiscountAmount,
    bool IsPercentage,
    DateTime ExpiresAt);