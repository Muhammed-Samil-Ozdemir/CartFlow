namespace CartFlow.Dtos.Products;

public sealed record ProductsStatisticsDto(
    int Total,
    int Active,
    int Passive,
    int OutOfStock);