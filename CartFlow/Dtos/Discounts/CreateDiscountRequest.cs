using CartFlow.Enums;

namespace CartFlow.Dtos.Discounts;

public sealed record CreateDiscountRequest(
    string? Name,
    decimal Amount,
    DiscountTargetType TargetType,
    bool IsPercentage);