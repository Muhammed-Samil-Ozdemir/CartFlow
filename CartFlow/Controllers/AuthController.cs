using CartFlow.Abstractions;
using CartFlow.Dtos.Auth;
using CartFlow.Dtos.Users;
using CartFlow.Services;
using Microsoft.AspNetCore.Mvc;

namespace CartFlow.Controllers;

[Route("auth")]
[ApiController]
public class AuthController(AuthService authService, UserService userService) : CustomBaseController
{
    [HttpPost]
    public async Task<IActionResult> Register(RegisterRequest request, CancellationToken cancellationToken) =>
        CreateActionResult(await userService.CreateAsync(request, cancellationToken));
    
    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request, CancellationToken cancellationToken) =>
        CreateActionResult(await authService.LoginAsync(request, cancellationToken));
}