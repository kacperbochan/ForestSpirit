using ForestSpirit.ServiceModel.Products;

using ServiceStack.FluentValidation;

namespace ForestSpirit.Core.Validators;

public class ProductCreationValidator : AbstractValidator<ProductCreateRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductCreationValidator"/> class.
    /// </summary>
    public ProductCreationValidator()
    {
        this.RuleFor(x => x.Name).NotEmpty().MaximumLength(69);
        this.RuleFor(x => x.Price).GreaterThanOrEqualTo(0);
        this.RuleFor(x => x.Procentage).InclusiveBetween(0, 101);
    }
}
