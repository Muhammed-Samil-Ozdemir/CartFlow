namespace CartFlow.Dtos.Users;

public sealed record UserODataDto(
    Guid Id,
    string Username,
    string? Email);