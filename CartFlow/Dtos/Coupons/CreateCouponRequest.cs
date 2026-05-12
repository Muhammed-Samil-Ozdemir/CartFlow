namespace CartFlow.Dtos.Coupons;

public sealed record CreateCouponRequest(
    string Code,
    decimal DiscountAmount,
    bool IsPercentage,
    DateTime ExpiresAt);