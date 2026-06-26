using CartFlow.Dtos.Categories;
using CartFlow.Dtos.Discounts;
using CartFlow.Dtos.Products;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;

namespace CartFlow.Extensions;

public static class ODataEdmModel
{
    public static IEdmModel Build()
    {
        ODataConventionModelBuilder builder = new();
        builder.EnableLowerCamelCase();
        builder.EntitySet<CategoryODataDto>("categories");
        builder.EntitySet<ProductODataDto>("products");
        builder.EntitySet<DiscountODataDto>("discounts");
        return builder.GetEdmModel();
    }
}