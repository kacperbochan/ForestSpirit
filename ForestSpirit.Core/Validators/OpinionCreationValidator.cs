using ForestSpirit.ServiceModel.Opinions;

using ServiceStack.FluentValidation;

namespace ForestSpirit.Core.Validators;

public class OpinionCreationValidator : AbstractValidator<OpinionCreateRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OpinionCreationValidator"/> class.
    /// </summary>
    public OpinionCreationValidator()
    {
        this.RuleFor(x => x).NotNull();
    }
}
