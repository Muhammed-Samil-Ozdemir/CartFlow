using CartFlow.Abstractions;
using CartFlow.Dtos.Coupons;
using CartFlow.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CartFlow.Controllers;

[Route("coupon")]
[ApiController]
[Authorize]
public class CouponController(CouponService service) : CustomBaseController
{
    [HttpPost]
    public async Task<IActionResult> Create(CreateCouponRequest request, CancellationToken cancellationToken) =>
        CreateActionResult(await service.CreateAsync(request, cancellationToken));
    
    [HttpGet]
    public async Task<IActionResult> GetByCode(string code, CancellationToken cancellationToken) =>
        CreateActionResult(await service.GetByCodeAsync(code, cancellationToken));
}