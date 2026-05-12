using CartFlow.Common;
using CartFlow.Dtos.Discounts;
using CartFlow.Models;
using CartFlow.Repositories;
using CartFlow.UnitOfWorks;

namespace CartFlow.Services;

public sealed class DiscountService(DiscountRepository repository, UnitOfWork unitOfWork)
{
    public async Task<Result<Guid>> CreateAsync(CreateDiscountRequest request, CancellationToken cancellationToken)
    {
        var discount = new Discount()
        {
            Name = request.Name,
            Amount = request.Amount,
            TargetType = request.TargetType,
            IsPercentage = request.IsPercentage
        };
        
        await repository.AddAsync(discount, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return Result<Guid>.Created(discount.Id);
    }
    
    public async Task<Result<List<DiscountDto>>> GetAllListAsync(CancellationToken cancellationToken)
    {
        var discounts = await repository.GetAllAsync(cancellationToken);
    
        var result = discounts
            .Select(d => new DiscountDto(d.Id, d.Name, d.Amount, d.TargetType, d.IsPercentage))
            .ToList();
    
        return Result<List<DiscountDto>>.Success(result);
    }
    
    public async Task<Result<DiscountDto>> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var discount = await repository.GetByIdAsync(id, cancellationToken);
        if (discount is null)
            return Result<DiscountDto>.NotFound("Discount not found!");
        
        var result = new DiscountDto(
            discount.Id,
            discount.Name,
            discount.Amount,
            discount.TargetType,
            discount.IsPercentage);
        
        return Result<DiscountDto>.Success(result);
    }

    public async Task<Result> DeleteByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var discount = await repository.GetByIdAsync(id, cancellationToken);
        if (discount is null)
            return Result.NotFound("Discount not found!");
        
        repository.Remove(discount);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return Result.Success();
    }
}