namespace CartFlow.Dtos.Users;

public sealed record UserDto(
    Guid Id,
    string Name,
    string? Email);