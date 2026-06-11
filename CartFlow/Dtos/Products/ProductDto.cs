namespace CartFlow.Dtos.Products;

public sealed record ProductDto(
    Guid Id,
    string Name,
    string? Description,
    decimal Price,
    int Stock,
    Guid? DiscountId,
    Guid CategoryId);