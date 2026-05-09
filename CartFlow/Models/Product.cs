using CartFlow.Abstractions;

namespace CartFlow.Models;

public sealed class Product : BaseEntity
{
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    
    public Guid? DiscountId { get; set; }
    public Discount? Discount { get; set; }
    
    public List<CartItem>? CartItems { get; set; }
}