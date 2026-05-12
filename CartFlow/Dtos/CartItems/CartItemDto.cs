namespace CartFlow.Dtos.CartItems;

public sealed record CartItemDto(
    Guid Id,
    Guid ProductId,
    Guid CartId,
    int Quantity,
    decimal UnitPrice,
    decimal SubTotal);