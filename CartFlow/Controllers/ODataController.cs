using CartFlow.Dtos.Categories;
using CartFlow.Dtos.Discounts;
using CartFlow.Dtos.Products;
using CartFlow.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace CartFlow.Controllers;

[Route("odata")]
[ApiController]
[Authorize]
[EnableQuery]
public class AppODataController(
    CategoryService categoryService,
    ProductService productService,
    DiscountService discountService) : ODataController
{
    [HttpGet("categories")]
    public IQueryable<CategoryODataDto> GetAllCategories() => categoryService.GetAll();

    [HttpGet("products")]
    public IQueryable<ProductODataDto> GetAllProducts() => productService.GetAll();

    [HttpGet("discounts")]
    public IQueryable<DiscountODataDto> GetAllDiscounts() => discountService.GetAll();
    
}