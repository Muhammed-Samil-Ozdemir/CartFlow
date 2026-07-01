using CartFlow.Abstractions;

namespace CartFlow.Models;

public sealed class Category : BaseEntity
{
    public string Name { get; set; } = default!;
    public bool IsActive { get; set; } = true;
    public int ColorIndex { get; set; }
    public int IconIndex { get; set; }
    
    public ICollection<Product>? Products { get; set; }
}