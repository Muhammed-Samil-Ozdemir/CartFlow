namespace CartFlow.Dtos.Products;

public sealed class ProductODataDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public int Sold { get; set; }
    public bool IsActive { get; set; }
    public Guid? DiscountId { get; set; }
    public Guid CategoryId { get; set; }
}