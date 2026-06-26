namespace CartFlow.Dtos.Products;

public sealed record CreateProductRequest(
    string Name,
    string? Description,
    decimal Price,
    int Stock,
    bool IsActive,
    Guid CategoryId);