using CartFlow.Abstractions;
using CartFlow.Dtos.Auth;
using CartFlow.Services;
using Microsoft.AspNetCore.Mvc;

namespace CartFlow.Controllers;

[Route("auth")]
[ApiController]
public class AuthController(AuthService service) : CustomBaseController
{
    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request, CancellationToken cancellationToken) =>
        CreateActionResult(await service.LoginAsync(request, cancellationToken));
}