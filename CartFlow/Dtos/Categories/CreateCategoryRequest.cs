namespace CartFlow.Dtos.Categories;

public sealed record CreateCategoryRequest(
    string Name,
    bool IsActive,
    int ColorIndex,
    int IconIndex);