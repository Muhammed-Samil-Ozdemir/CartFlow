namespace CartFlow.Dtos.Users;

public sealed record RegisterRequest(string Name, string Email, string Password);