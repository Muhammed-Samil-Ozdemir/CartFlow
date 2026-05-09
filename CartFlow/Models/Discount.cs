using CartFlow.Abstractions;

namespace CartFlow.Models;

public sealed class Discount : BaseEntity
{
    public string? Name { get; set; }
    public decimal Amount { get; set; }
    public string TargetType { get; set; } = default!;
    public bool IsPercentage { get; set; }
    
    public List<Product>? Products { get; set; }
}