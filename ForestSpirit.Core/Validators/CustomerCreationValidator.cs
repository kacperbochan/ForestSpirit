using ForestSpirit.ServiceModel.Customers;

using ServiceStack.FluentValidation;

namespace ForestSpirit.Core.Validators;

public class CustomerCreationValidator : AbstractValidator<CustomerCreateRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CustomerCreationValidator"/> class.
    /// </summary>
    public CustomerCreationValidator()
    {
        this.RuleFor(x => x).NotNull();
    }
}
