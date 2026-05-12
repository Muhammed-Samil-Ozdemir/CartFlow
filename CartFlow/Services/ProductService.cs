using CartFlow.Common;
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
            Price = request.Price
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
        
        repository.Update(product);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return Result<Guid>.Success(product.Id);
    }
    
    public async Task<Result<List<ProductDto>>> GetAllAsync(CancellationToken cancellationToken)
    {
        var products = await repository.GetAllAsync(cancellationToken);
    
        var result = products
            .Select(p => new ProductDto(p.Id, p.Name, p.Description, p.Price, p.Stock, p.DiscountId))
            .ToList();
    
        return Result<List<ProductDto>>.Success(result);
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
            product.DiscountId);
        
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
}