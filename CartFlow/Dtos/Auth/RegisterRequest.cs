namespace CartFlow.Dtos.Auth;

public sealed record RegisterRequest(string Username, string Email, string Password);