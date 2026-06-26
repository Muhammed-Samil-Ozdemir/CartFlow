using CartFlow.Common;
using CartFlow.Dtos;
using CartFlow.Dtos.Categories;
using CartFlow.Dtos.Discounts;
using CartFlow.Models;
using CartFlow.Repositories;
using CartFlow.UnitOfWorks;

namespace CartFlow.Services;

public sealed class CategoryService(
    CategoryRepository repository,
    UnitOfWork unitOfWork)
{
    public async Task<Result<Guid>> CreateAsync(CreateCategoryRequest request, CancellationToken cancellationToken)
    {
        var isExist = await repository.AnyAsync(c => c.Name == request.Name, cancellationToken);
        if (isExist)
            return Result<Guid>.Conflict("Category already exists!");
        
        var category = new Category()
        {
            Name = request.Name
        };
        
        await repository.AddAsync(category, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return Result<Guid>.Created(category.Id);
    }
    
    public async Task<Result<Guid>> UpdateAsync(Guid id, UpdateCategoryRequest request,
        CancellationToken cancellationToken)
    {
        var isExist = await repository.AnyAsync(c => c.Name == request.Name, cancellationToken);
        if (isExist)
            return Result<Guid>.Conflict("Category already exists!");
        
        var category = await repository.GetByIdAsync(id, cancellationToken);
        if (category is null)
            return Result<Guid>.NotFound("Category not found!");
        
        category.Name = request.Name;
        
        repository.Update(category);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return Result<Guid>.Success(category.Id);
    }
    
    public async Task<Result> DeleteByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var category = await repository.GetByIdAsync(id, cancellationToken);
        if (category is null)
            return Result.NotFound("Category not found!");
        
        repository.Remove(category);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return Result.Success();
    }

    public async Task<Result<CategoryDto>> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var category = await repository.GetByIdAsync(id, cancellationToken);
        if (category is null)
            return Result<CategoryDto>.NotFound("Product not found!");
        
        var result = new CategoryDto(category.Id, category.Name);
        
        return Result<CategoryDto>.Success(result);
    }

    public IQueryable<CategoryODataDto> GetAll() =>
        repository.GetAllQueryable()
            .Select(c => new CategoryODataDto(c.Id, c.Name));
    
    public Task<Result<StatisticsDto>> GetStatisticsAsync(CancellationToken cancellationToken)
    {
        var totals = repository.GetAllQueryable().Count();
        var actives = repository.GetWhere(c => c.Products!.Any()).Count();
        var passives = repository.GetWhere(c => !c.Products!.Any()).Count();

        return Task.FromResult(Result<StatisticsDto>.Success(
            new StatisticsDto(totals, actives, passives)));
    }
}