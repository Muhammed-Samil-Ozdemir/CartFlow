using CartFlow.Abstractions;

namespace CartFlow.Models;

public sealed class Category : BaseEntity
{
    public string Name { get; set; } = default!;
    
    public List<Product>? Products { get; set; }
}