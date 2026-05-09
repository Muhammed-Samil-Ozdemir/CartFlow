using CartFlow.Common;
using CartFlow.Dtos;
using CartFlow.Repositories;

namespace CartFlow.Services;

public sealed class CartService(CartRepository repository)
{
    public async Task<Result<List<CartDto>>> GetAllListAsync(CancellationToken cancellationToken)
    {
        var carts = await repository.GetAllListAsync(cancellationToken);
        
        var result = carts.Select(cart => new CartDto(
            cart.UserId,
            cart.CouponId,
            cart.IsCheckedOut,
            cart.CartItems?.Select(c =>
                new CartItemDto(
                    c.ProductId,
                    c.Quantity,
                    c.UnitPrice)).ToList() ?? new())).ToList();
        
        return Result<List<CartDto>>.Success(result);
    }

    public async Task<Result<CartDto>> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var cart = await repository.GetByIdAsync(id, cancellationToken);
        if (cart is null)
            return Result<CartDto>.NotFound("Cart not found!");

        var result = new CartDto(cart.UserId, cart.CouponId, cart.IsCheckedOut, cart.CartItems?.Select(c =>
            new CartItemDto(
                c.ProductId,
                c.Quantity,
                c.UnitPrice)).ToList() ?? new());
        
        return Result<CartDto>.Success(result);
    }
    
    
}