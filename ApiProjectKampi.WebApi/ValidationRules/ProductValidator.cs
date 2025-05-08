using ApiProjectKampi.WebApi.Entities;
using FluentValidation;

namespace ApiProjectKampi.WebApi.ValidationRules
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Product name cannot be empty");
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("Product name must be at least 2 characters long");
            RuleFor(x=>x.ProductName).MaximumLength(50).WithMessage("Product name must be at most 50 characters long");

            RuleFor(x=>x.ProductPrice).NotEmpty().WithMessage("Product price cannot be empty").GreaterThan(0).WithMessage("Product price must be greater than 0").LessThan(1000).WithMessage("Product price cannot be greater than 1000");
            RuleFor(x=>x.ProductDescription).NotEmpty().WithMessage("Product description cannot be empty");


        }
    }
    
}
