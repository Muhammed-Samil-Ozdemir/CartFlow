using CartFlow.Common;
using CartFlow.Dtos.CartItems;
using CartFlow.Dtos.Carts;
using CartFlow.Models;
using CartFlow.Repositories;
using CartFlow.UnitOfWorks;

namespace CartFlow.Services;

public sealed class CartService(CartRepository cartRepository, CouponRepository couponRepository, UnitOfWork unitOfWork)
{
    public async Task<Result<Guid>> CreateAsync(CreateCartRequest request, CancellationToken cancellationToken)
    {
        var cart = new Cart()
        {
            UserId = request.UserId,
            IsCheckedOut = request.IsCheckedOut
        };
        
        await cartRepository.AddAsync(cart, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return Result<Guid>.Created(cart.Id);
    }
    
    public async Task<Result<CartDto>> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var cart = await cartRepository.GetByIdAsync(id, cancellationToken);
        if (cart is null)
            return Result<CartDto>.NotFound("Cart not found!");
        
        var cartItems = cart.CartItems!.Select(ci => new CartItemDto(
            ci.Id,
            ci.ProductId,
            ci.CartId,
            ci.Quantity,
            ci.UnitPrice,
            ci.Quantity * ci.UnitPrice)).ToList();
        
        var totalPrice = cartItems.Sum(ci => ci.SubTotal);
        
        var result = new CartDto(
            cart.Id,
            cart.UserId,
            cart.CouponId,
            cart.IsCheckedOut,
            totalPrice,
            cartItems);
        
        return Result<CartDto>.Success(result);
    }

    public async Task<Result> ApplyCouponAsync(Guid cartId, ApplyCouponRequest request, CancellationToken cancellationToken)
    {
        var cart = await cartRepository.GetByIdAsync(cartId, cancellationToken);
        if (cart is null)
            return Result.NotFound("Cart not found!");
        
        var coupon = await couponRepository.GetByIdAsync(request.CouponId, cancellationToken);
        if (coupon is null)
            return Result.NotFound("Coupon not found!");
        
        cart.CouponId = request.CouponId;

        cartRepository.Update(cart);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return Result.Success();
    }
}