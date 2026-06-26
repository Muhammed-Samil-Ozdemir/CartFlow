using CartFlow.Dtos.Categories;

namespace CartFlow.Dtos.Products;

public sealed record ProductDto(
    Guid Id,
    string Name,
    string? Description,
    decimal Price,
    int Stock,
    bool IsActive,
    Guid? DiscountId,
    Guid CategoryId);