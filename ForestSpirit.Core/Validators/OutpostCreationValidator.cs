using ForestSpirit.ServiceModel.Outposts;

using ServiceStack.FluentValidation;

namespace ForestSpirit.Core.Validators;

public class OutpostCreationValidator : AbstractValidator<OutpostCreateRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OutpostCreationValidator"/> class.
    /// </summary>
    public OutpostCreationValidator()
    {
        this.RuleFor(x => x).NotNull();
    }
}
