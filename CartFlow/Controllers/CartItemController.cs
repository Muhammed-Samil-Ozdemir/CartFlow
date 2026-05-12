using CartFlow.Abstractions;
using CartFlow.Dtos.CartItems;
using CartFlow.Services;
using Microsoft.AspNetCore.Mvc;

namespace CartFlow.Controllers;

[Route("cart-item")]
[ApiController]
public class CartItemController(CartItemService service) : CustomBaseController
{
    [HttpPost]
    public async Task<IActionResult> AddItem(
        Guid cartId,
        AddItemRequest request,
        CancellationToken cancellationToken) =>
        CreateActionResult(await service.AddItemAsync(cartId, request, cancellationToken));
    
    [HttpPatch]
    public async Task<IActionResult> UpdateQuantity(
        Guid id,
        UpdateQuantityRequest request,
        CancellationToken cancellationToken) =>
        CreateActionResult(await service.UpdateQuantityAsync(id, request, cancellationToken));
    
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> RemoveById(Guid id, CancellationToken cancellationToken) =>
        CreateActionResult(await service.RemoveByIdAsync(id, cancellationToken));
    
    [HttpDelete("{id:guid}/clear")]
    public async Task<IActionResult> ClearCart(Guid cartId, CancellationToken cancellationToken) =>
        CreateActionResult(await service.ClearCartAsync(cartId, cancellationToken));
}