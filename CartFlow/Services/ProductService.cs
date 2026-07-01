using CartFlow.Common;
using CartFlow.Dtos;
using CartFlow.Dtos.Categories;
using CartFlow.Dtos.Discounts;
using CartFlow.Dtos.Products;
using CartFlow.Models;
using CartFlow.Repositories;
using CartFlow.UnitOfWorks;

namespace CartFlow.Services;

public sealed class ProductService(ProductRepository repository, UnitOfWork unitOfWork)
{
    public async Task<Result<Guid>> CreateAsync(CreateProductRequest request, CancellationToken cancellationToken)
    {
        var product = new Product()
        {
            Name = request.Name,
            Description = request.Description,
            Price = request.Price,
            Stock = request.Stock,
            IsActive = request.IsActive,
            CategoryId = request.CategoryId
        };
        
        await repository.AddAsync(product, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return Result<Guid>.Created(product.Id);
    }
    
    public async Task<Result<Guid>> UpdateAsync(
        Guid id,
        UpdateProductRequest request,
        CancellationToken cancellationToken)
    {
        var product = await repository.GetByIdAsync(id, cancellationToken);
        if (product is null)
            return Result<Guid>.NotFound("Product not found!");
        
        product.Name = request.Name;
        product.Description = request.Description;
        product.Price = request.Price;
        product.Stock = request.Stock;
        product.IsActive = request.IsActive;
        product.CategoryId = request.CategoryId;
        
        repository.Update(product);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return Result<Guid>.Success(product.Id);
    }
    
    public async Task<Result<ProductDto>> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var product = await repository.GetByIdAsync(id, cancellationToken);
        if (product is null)
            return Result<ProductDto>.NotFound("Product not found!");
        
        var result = new ProductDto(
            product.Id,
            product.Name,
            product.Description,
            product.Price,
            product.Stock,
            product.Sold,
            product.IsActive,
            product.DiscountId,
            product.CategoryId);
        
        return Result<ProductDto>.Success(result);
    }
    
    public async Task<Result> DeleteByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var product = await repository.GetByIdAsync(id, cancellationToken);
        if (product is null)
            return Result.NotFound("Product not found!");
        
        repository.Remove(product);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return Result.Success();
    }
    
    public IQueryable<ProductODataDto> GetAll() =>
        repository.GetAllQueryable()
            .Select(p => new ProductODataDto
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                Stock = p.Stock,
                Sold = p.Sold,
                IsActive = p.IsActive,
                DiscountId = p.DiscountId,
                CategoryId = p.CategoryId
            });
    
    public Task<Result<ProductsStatisticsDto>> GetStatisticsAsync(CancellationToken cancellationToken)
    {
        var totals = repository.GetAllQueryable().Count();
        var actives = repository.GetWhere(c => c.IsActive).Count();
        var passives = repository.GetWhere(c => !c.IsActive).Count();
        var outOfStock = repository.GetWhere(c => c.Stock <= 0).Count();

        return Task.FromResult(Result<ProductsStatisticsDto>.Success(
            new ProductsStatisticsDto(totals, actives, passives, outOfStock)));
    }
}
