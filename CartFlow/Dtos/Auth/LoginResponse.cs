namespace CartFlow.Dtos.Auth;

public sealed record LoginResponse(Guid Id, string Token, string RefreshToken);