namespace CartFlow.Dtos.Products;

public sealed record ProductODataDto(
    Guid Id,
    string Name,
    string? Description,
    decimal Price,
    int Stock,
    bool IsActive,
    Guid? DiscountId,
    Guid CategoryId);