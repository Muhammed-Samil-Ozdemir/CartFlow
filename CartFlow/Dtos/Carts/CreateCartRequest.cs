namespace CartFlow.Dtos.Carts;

public sealed record CreateCartRequest(Guid UserId, bool IsCheckedOut = false);