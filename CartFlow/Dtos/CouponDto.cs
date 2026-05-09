namespace CartFlow.Dtos;

public sealed record CouponDto(
    string Code,
    decimal DiscountAmount,
    DateTime ExpiresAt,
    bool IsPercentage);