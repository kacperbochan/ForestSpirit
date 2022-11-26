using ForestSpirit.ServiceModel.Equipments;

using ServiceStack.FluentValidation;

namespace ForestSpirit.Core.Validators;

public class EquipmentCreationValidator : AbstractValidator<EquipmentCreateRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EquipmentCreationValidator"/> class.
    /// </summary>
    public EquipmentCreationValidator()
    {
        this.RuleFor(x => x).NotNull();
    }
}
