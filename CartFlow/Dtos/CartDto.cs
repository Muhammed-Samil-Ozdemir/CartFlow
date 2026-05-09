using CartFlow.Models;

namespace CartFlow.Dtos;

public sealed record CartDto(
    Guid UserId,
    Guid? CouponId,
    bool IsCheckedOut,
    List<CartItemDto> CartItems);