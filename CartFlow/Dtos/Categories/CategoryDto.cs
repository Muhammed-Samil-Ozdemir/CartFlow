namespace CartFlow.Dtos.Categories;

public sealed record CategoryDto(
    Guid Id,
    string Name,
    bool IsActive,
    int IconIndex,
    int ColorIndex);