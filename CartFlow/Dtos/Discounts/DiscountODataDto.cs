using CartFlow.Enums;

namespace CartFlow.Dtos.Discounts;

public sealed record DiscountODataDto(
    Guid Id,
    string? Name,
    decimal Amount,
    DiscountTargetType TargetType,
    bool IsPercentage);