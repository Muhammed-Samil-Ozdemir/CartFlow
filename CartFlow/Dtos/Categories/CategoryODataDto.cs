namespace CartFlow.Dtos.Categories;

public sealed record CategoryODataDto(
    Guid Id,
    string Name,
    bool IsActive,
    int ColorIndex,
    int IconIndex,
    decimal AveragePrice,
    int ProductCount);