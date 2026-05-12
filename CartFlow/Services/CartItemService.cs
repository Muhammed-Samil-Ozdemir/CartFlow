using CartFlow.Common;
using CartFlow.Dtos.CartItems;
using CartFlow.Models;
using CartFlow.Repositories;
using CartFlow.UnitOfWorks;

namespace CartFlow.Services;

public sealed class CartItemService(
    CartItemRepository cartItemRepository,
    CartRepository cartRepository,
    ProductRepository productRepository,
    UnitOfWork unitOfWork)
{
    public async Task<Result<Guid>> AddItemAsync(
        Guid cartId,
        AddItemRequest request,
        CancellationToken cancellationToken)
    {
        var cart = await cartRepository.GetByIdAsync(cartId, cancellationToken);
        if (cart is null)
            return Result<Guid>.NotFound("Cart not found!");
        
        var product = await productRepository.GetByIdAsync(request.ProductId, cancellationToken);
        if (product is null)
            return Result<Guid>.NotFound("Product not found!");
        
        var existingItem = await cartItemRepository.GetFirstByExpressionAsync(
            ci => ci.CartId == cartId && ci.ProductId == request.ProductId, cancellationToken);

        if (existingItem is null)
        {
            var cartItem = new CartItem()
            {
                CartId = cartId,
                ProductId = request.ProductId,
                Quantity = request.Quantity,
                UnitPrice = product.Price
            };
        
            await cartItemRepository.AddAsync(cartItem, cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);
            
            return Result<Guid>.Success(cartItem.Id);
        }

        existingItem.Quantity += request.Quantity;
        
        cartItemRepository.Update(existingItem);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return Result<Guid>.Success(existingItem.Id);
    }

    public async Task<Result> UpdateQuantityAsync(
        Guid id,
        UpdateQuantityRequest request,
        CancellationToken cancellationToken)
    {
        var cartItem = await cartItemRepository.GetByIdAsync(id, cancellationToken);
        if (cartItem is null)
            return Result.NotFound("CartItem not found!");
        
        cartItem.Quantity = request.Quantity;
        
        cartItemRepository.Update(cartItem);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return Result.Success();
    }
    
    public async Task<Result> RemoveByIdAsync(Guid cartItemId, CancellationToken cancellationToken)
    {
        var cartItem = await cartItemRepository.GetByIdAsync(cartItemId, cancellationToken);
        if (cartItem is null)
            return Result.NotFound("Cart item not found!");
        
        cartItemRepository.Remove(cartItem);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return Result.Success();
    }
    
    public async Task<Result> ClearCartAsync(Guid cartId, CancellationToken cancellationToken)
    {
        var cart = await cartRepository.GetByIdAsync(cartId, cancellationToken);
        if (cart is null)
            return Result.NotFound("Cart not found!");

        var items = await cartItemRepository.GetByCartIdAsync(cartId, cancellationToken);
    
        cartItemRepository.RemoveRange(items);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    
        return Result.Success();
    }
}