using CartFlow.Abstractions;
using CartFlow.Dtos.Categories;
using CartFlow.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CartFlow.Controllers;

[Route("categories")]
[ApiController]
[Authorize]
public class CategoryController(CategoryService service) : CustomBaseController
{
    [HttpPost]
    public async Task<IActionResult> Create(CreateCategoryRequest request, CancellationToken cancellationToken) =>
        CreateActionResult(await service.CreateAsync(request, cancellationToken));
    
    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update(Guid id, UpdateCategoryRequest request, CancellationToken cancellationToken) =>
        CreateActionResult(await service.UpdateAsync(id, request, cancellationToken));
    
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken) =>
        CreateActionResult(await service.GetByIdAsync(id, cancellationToken));
    
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteById(Guid id, CancellationToken cancellationToken) =>
        CreateActionResult(await service.DeleteByIdAsync(id, cancellationToken));
    
    [HttpGet("statistics")]
    public async Task<IActionResult> GetStatistics(CancellationToken cancellationToken) =>
        CreateActionResult(await service.GetStatisticsAsync(cancellationToken));
}