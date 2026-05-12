using CartFlow.Abstractions;
using CartFlow.Enums;

namespace CartFlow.Models;

public sealed class Discount : BaseEntity
{
    public string? Name { get; set; }
    public decimal Amount { get; set; }
    public DiscountTargetType TargetType { get; set; }
    public bool IsPercentage { get; set; }
    
    public List<Product>? Products { get; set; }
}