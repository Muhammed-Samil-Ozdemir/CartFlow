using CartFlow.Common;
using CartFlow.Dtos;
using CartFlow.Dtos.Categories;
using CartFlow.Dtos.Discounts;
using CartFlow.Models;
using CartFlow.Repositories;
using CartFlow.UnitOfWorks;

namespace CartFlow.Services;

public sealed class CategoryService(
    CategoryRepository categoryRepository,
    ProductRepository productRepository,
    UnitOfWork unitOfWork)
{
    public async Task<Result<Guid>> CreateAsync(CreateCategoryRequest request, CancellationToken cancellationToken)
    {
        var isExist = await categoryRepository.AnyAsync(c => c.Name == request.Name, cancellationToken);
        if (isExist)
            return Result<Guid>.Conflict("Category already exists!");
        
        var category = new Category()
        {
            Name = request.Name,
            IsActive = request.IsActive,
            ColorIndex = request.ColorIndex,
            IconIndex = request.IconIndex
        };
        
        await categoryRepository.AddAsync(category, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return Result<Guid>.Created(category.Id);
    }
    
    public async Task<Result<Guid>> UpdateAsync(Guid id, UpdateCategoryRequest request,
        CancellationToken cancellationToken)
    {
        var isExist = await categoryRepository.AnyAsync(c => c.Name == request.Name, cancellationToken);
        if (isExist)
            return Result<Guid>.Conflict("Category already exists!");
        
        var category = await categoryRepository.GetByIdAsync(id, cancellationToken);
        if (category is null)
            return Result<Guid>.NotFound("Category not found!");
        
        category.Name = request.Name;
        category.IsActive = request.IsActive;
        category.ColorIndex = request.ColorIndex;
        category.IconIndex = request.IconIndex;
        
        categoryRepository.Update(category);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return Result<Guid>.Success(category.Id);
    }
    
    public async Task<Result> DeleteByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var category = await categoryRepository.GetByIdAsync(id, cancellationToken);
        if (category is null)
            return Result.NotFound("Category not found!");
        
        var hasProducts = await productRepository.AnyAsync(p => p.CategoryId == id, cancellationToken);
        if (hasProducts)
            return Result.Conflict("Category has products. Remove or reassign them first.");
        
        categoryRepository.Remove(category);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return Result.Success();
    }

    public async Task<Result<CategoryDto>> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var category = await categoryRepository.GetByIdAsync(id, cancellationToken);
        if (category is null)
            return Result<CategoryDto>.NotFound("Product not found!");
        
        var result = new CategoryDto(
            category.Id,
            category.Name,
            category.IsActive,
            category.IconIndex,
            category.ColorIndex);
        
        return Result<CategoryDto>.Success(result);
    }

    public IQueryable<CategoryODataDto> GetAll() =>
        categoryRepository.GetAllQueryable()
            .Select(c => new CategoryODataDto(c.Id, c.Name, c.IsActive, c.ColorIndex, c.IconIndex));
    
    public Task<Result<StatisticsDto>> GetStatisticsAsync(CancellationToken cancellationToken)
    {
        var totals = categoryRepository.GetAllQueryable().Count();
        var actives = categoryRepository.GetWhere(c => c.IsActive).Count();
        var passives = categoryRepository.GetWhere(c => !c.IsActive).Count();

        return Task.FromResult(Result<StatisticsDto>.Success(
            new StatisticsDto(totals, actives, passives)));
    }
}