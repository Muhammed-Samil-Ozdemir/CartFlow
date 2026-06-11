using CartFlow.Dtos.Products;
using FluentValidation;

namespace CartFlow.Validators.Products;

public sealed class CreateProductRequestValidator : AbstractValidator<CreateProductRequest>
{
    public CreateProductRequestValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Product name is required.")
            .MaximumLength(100).WithMessage("Product name must not exceed 100 characters.");
        
        RuleFor(x => x.Description)
            .MaximumLength(500).WithMessage("Product description must not exceed 500 characters.");
        
        RuleFor(x => x.Price)
            .GreaterThan(0).WithMessage("Price must be greater than 0.");
        
        RuleFor(x => x.Stock)
            .GreaterThanOrEqualTo(0).WithMessage("Stock must be 0 or greater.");
    }
}