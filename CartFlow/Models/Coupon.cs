using CartFlow.Abstractions;

namespace CartFlow.Models;

public sealed class Coupon : BaseEntity
{
    public string Code { get; set; } = default!;
    public decimal DiscountAmount { get; set; }
    public DateTime ExpiresAt { get; set; }
    public bool IsPercentage { get; set; }
    
    public Guid? CartId { get; set; }
    public Cart? Cart { get; set; }
}