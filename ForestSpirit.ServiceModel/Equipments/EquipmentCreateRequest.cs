using ServiceStack;
using ServiceStack.DataAnnotations;

namespace ForestSpirit.ServiceModel.Equipments;

[Route("/equipment/create", "POST")]
public class EquipmentCreateRequest : IReturn<EquipmentData>
{
    public string Name { get; set; }

    public string SerialNumber { get; set; }

    public int OutpostId { get; set; }
}
