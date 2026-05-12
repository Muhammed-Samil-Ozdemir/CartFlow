using CartFlow.Common;
using CartFlow.Dtos.Auth;
using CartFlow.Providers;
using CartFlow.Repositories;

namespace CartFlow.Services;

public sealed class AuthService(
    UserRepository userRepository,
    JwtProvider jwtProvider)
{
    public async Task<Result<string>> LoginAsync(LoginRequest request, CancellationToken cancellationToken)
    {
        var user = await userRepository.GetByEmailAsync(request.Email, cancellationToken);
        if (user is null)
            return Result<string>.Failure("Invalid email or password!");
        
        var checkPassword = user.VerifyPassword(request.Password);
        if (!checkPassword)
            return Result<string>.Failure("Invalid email or password!");
        
        var token = jwtProvider.CreateToken(user);
        
        return Result<string>.Success(token);
    }
}