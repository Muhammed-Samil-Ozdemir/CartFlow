namespace CartFlow.Dtos;

public sealed record StatisticsDto(
    int Total,
    int Active,
    int Passive);