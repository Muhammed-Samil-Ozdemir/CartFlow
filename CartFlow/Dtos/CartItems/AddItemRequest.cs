namespace CartFlow.Dtos.CartItems;

public sealed record AddItemRequest(
    Guid ProductId,
    int Quantity);