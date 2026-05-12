using CartFlow.Common;
using CartFlow.Dtos.Users;
using CartFlow.Models;
using CartFlow.Repositories;
using CartFlow.UnitOfWorks;

namespace CartFlow.Services;

public sealed class UserService(UserRepository repository, UnitOfWork unitOfWork)
{
    public async Task<Result<Guid>> CreateAsync(RegisterRequest request, CancellationToken cancellationToken)
    {
        var user = new User()
        {
            Name = request.Name,
            Email = request.Email
        };
        
        await repository.AddAsync(user, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return Result<Guid>.Created(user.Id);
    }

    public async Task<Result<UserDto>> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var user = await repository.GetByIdAsync(id, cancellationToken);
        if (user is null)
            return Result<UserDto>.NotFound("User not found!");
        
        var result = new UserDto(
            user.Id,
            user.Name,
            user.Email);
        
        return Result<UserDto>.Success(result);
    }

    public async Task<Result> DeleteByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var user = await repository.GetByIdAsync(id, cancellationToken);
        if (user is null)
            return Result<UserDto>.NotFound("Discount not found!");
        
        repository.Remove(user);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return Result.Success();
    }
}