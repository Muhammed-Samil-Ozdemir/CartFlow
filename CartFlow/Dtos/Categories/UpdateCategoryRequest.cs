namespace CartFlow.Dtos.Categories;

public sealed record UpdateCategoryRequest(
    string Name,
    bool IsActive,
    int ColorIndex,
    int IconIndex);