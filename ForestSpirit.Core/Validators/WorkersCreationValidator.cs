using ForestSpirit.ServiceModel.Workers;

using ServiceStack.FluentValidation;

namespace ForestSpirit.Core.Validators;

public class WorkersCreationValidator : AbstractValidator<WorkerCreateRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkersCreationValidator"/> class.
    /// </summary>
    public WorkersCreationValidator()
    {
        this.RuleFor(x => x).NotNull();
    }
}
