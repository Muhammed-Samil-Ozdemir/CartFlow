using CartFlow.Abstractions;
using CartFlow.Dtos.Discounts;
using CartFlow.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CartFlow.Controllers;

[Route("discount")]
[ApiController]
[Authorize]
public class DiscountController(DiscountService service) : CustomBaseController
{
    [HttpPost]
    public async Task<IActionResult> Create(CreateDiscountRequest request, CancellationToken cancellationToken) =>
        CreateActionResult(await service.CreateAsync(request, cancellationToken));
    
    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken) =>
        CreateActionResult(await service.GetAllAsync(cancellationToken));
    
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken) =>
        CreateActionResult(await service.GetByIdAsync(id, cancellationToken));
    
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteById(Guid id, CancellationToken cancellationToken) =>
        CreateActionResult(await service.DeleteByIdAsync(id, cancellationToken));
}