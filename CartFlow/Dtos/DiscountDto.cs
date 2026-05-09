namespace CartFlow.Dtos;

public sealed record DiscountDto(
    string? Name,
    decimal Amount,
    string TargetType,
    bool IsPercentage);