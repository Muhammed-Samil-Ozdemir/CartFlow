using CartFlow.Abstractions;
using CartFlow.Dtos.Users;
using CartFlow.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CartFlow.Controllers;

[Route("user")]
[ApiController]
[Authorize]
public class UserController(UserService service) : CustomBaseController
{
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken) =>
        CreateActionResult(await service.GetByIdAsync(id, cancellationToken));
    
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteById(Guid id, CancellationToken cancellationToken) =>
        CreateActionResult(await service.DeleteByIdAsync(id, cancellationToken));
}