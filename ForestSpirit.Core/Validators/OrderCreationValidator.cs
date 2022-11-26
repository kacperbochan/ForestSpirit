using ForestSpirit.ServiceModel.Orders;

using ServiceStack.FluentValidation;

namespace ForestSpirit.Core.Validators;

public class OrderCreationValidator : AbstractValidator<OrderCreateRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OrderCreationValidator"/> class.
    /// </summary>
    public OrderCreationValidator()
    {
        this.RuleFor(x => x).NotNull();
    }
}
