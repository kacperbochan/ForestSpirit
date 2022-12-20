using ForestSpirit.ServiceModel.Resources;

using ServiceStack.FluentValidation;

namespace ForestSpirit.Core.Validators;

public class ResourcesCreationValidator : AbstractValidator<ResourceCreateRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ResourcesCreationValidator"/> class.
    /// </summary>
    public ResourcesCreationValidator()
    {
        this.RuleFor(x => x).NotNull();
    }
}
