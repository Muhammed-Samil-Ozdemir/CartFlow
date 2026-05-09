using CartFlow.Abstractions;

namespace CartFlow.Models;

public class Cart : BaseEntity
{
    public Guid UserId { get; set; }
    public User User { get; set; } = default!;
    
    public Guid? CouponId { get; set; }
    public Coupon? Coupon { get; set; }
    
    public bool IsCheckedOut { get; set; }
    
    public List<CartItem>? CartItems { get; set; }
}