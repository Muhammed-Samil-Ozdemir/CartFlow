using CartFlow.Common;
using CartFlow.Dtos.Auth;
using CartFlow.Dtos.Users;
using CartFlow.Models;
using CartFlow.Providers;
using CartFlow.Repositories;
using CartFlow.UnitOfWorks;

namespace CartFlow.Services;

public sealed class AuthService(
    UserRepository userRepository,
    UnitOfWork unitOfWork,
    JwtProvider jwtProvider)
{
    public async Task<Result<Guid>> CreateAsync(RegisterRequest request, CancellationToken cancellationToken)
    {
        var isExist = await userRepository.AnyAsync(u => u.Email == request.Email, cancellationToken);
        if (isExist)
            return Result<Guid>.Conflict("Email already exists!");
            
        var user = new User()
        {
            Name = request.Name,
            Email = request.Email,
            Password = request.Password,
        };
        
        await userRepository.AddAsync(user, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return Result<Guid>.Created(user.Id);
    }
    
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