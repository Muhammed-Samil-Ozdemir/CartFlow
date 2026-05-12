using CartFlow.Enums;

namespace CartFlow.Dtos.Discounts;

public sealed record DiscountDto(
    Guid Id,
    string? Name,
    decimal Amount,
    DiscountTargetType TargetType,
    bool IsPercentage);