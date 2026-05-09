namespace CartFlow.Dtos;

public sealed record CartItemDto(
    Guid ProductId,
    int Quantity,
    decimal UnitPrice);