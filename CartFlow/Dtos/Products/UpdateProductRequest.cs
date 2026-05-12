namespace CartFlow.Dtos.Products;

public sealed record UpdateProductRequest(
    string Name,
    string? Description,
    decimal Price,
    int Stock);