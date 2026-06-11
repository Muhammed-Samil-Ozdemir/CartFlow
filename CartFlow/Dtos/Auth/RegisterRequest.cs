namespace CartFlow.Dtos.Auth;

public sealed record RegisterRequest(string Name, string Email, string Password);