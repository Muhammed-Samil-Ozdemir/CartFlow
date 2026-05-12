using CartFlow.Abstractions;

namespace CartFlow.Models;

public sealed class User : BaseEntity
{
    public string Name { get; set; } = default!;
    public string? Email { get; set; }
    public string Password { get; set; } = default!;
    
    public List<Cart>? Carts { get; set; }
    
    public bool VerifyPassword(string password) => password == Password;
    
}