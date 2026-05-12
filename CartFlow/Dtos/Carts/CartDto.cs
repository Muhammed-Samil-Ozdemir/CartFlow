using CartFlow.Dtos.CartItems;

namespace CartFlow.Dtos.Carts;

public sealed record CartDto(
    Guid Id,
    Guid UserId,
    Guid? CouponId,
    bool IsCheckedOut,
    decimal TotalPrice,
    List<CartItemDto> CartItems);