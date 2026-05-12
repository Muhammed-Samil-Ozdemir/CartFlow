using CartFlow.Abstractions;
using CartFlow.Dtos.Carts;
using CartFlow.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CartFlow.Controllers;

[Route("cart")]
[ApiController]
[Authorize]
public class CartController(CartService service) : CustomBaseController
{
    [HttpPost]
    public async Task<IActionResult> Create(CreateCartRequest request, CancellationToken cancellationToken) =>
        CreateActionResult(await service.CreateAsync(request, cancellationToken));
    
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken) =>
        CreateActionResult(await service.GetByIdAsync(id, cancellationToken));
    
    [HttpPost("{id:guid}/apply-coupon")]
    public async Task<IActionResult> ApplyCoupon(
        Guid cartId,
        ApplyCouponRequest request,
        CancellationToken cancellationToken) =>
        CreateActionResult(await service.ApplyCouponAsync(cartId, request, cancellationToken));
}