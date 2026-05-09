using CartFlow.Abstractions;

namespace CartFlow.Models;

public class CartItem : BaseEntity
{
    public Guid ProductId { get; set; }
    public Product Product { get; set; } = default!;
    
    public Guid CartId { get; set; }
    public Cart Cart { get; set; } = default!;
    
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
}