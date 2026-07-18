using AzMPA101Api.Dto;
using FluentValidation;

namespace AzMPA101Api.Validators;

public class ProductCreateValidator : AbstractValidator<ProductCreateDto>
{
    public ProductCreateValidator()
    {
        RuleFor(x=>x.Name).NotEmpty().WithMessage("Name is required.");
        RuleFor(x=>x.Name).MinimumLength(3).WithMessage("Name must be at least 3 characters long.");

        RuleFor(x=>x.Price).GreaterThan(0).WithMessage("Price must be greater than 0.");
    }
}
