using CartFlow.Abstractions;

namespace CartFlow.Models;

public sealed class User : BaseEntity
{
    public string Name { get; set; } = default!;
    public string? Email { get; set; }
    public string? Password { get; set; }
    
    public List<Cart>? Carts { get; set; }
}