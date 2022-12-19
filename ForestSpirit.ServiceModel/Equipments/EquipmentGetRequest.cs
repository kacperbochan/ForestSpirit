using ServiceStack;

namespace ForestSpirit.ServiceModel.Equipments;

[Route("/equipment/get/{Id}", "GET")]
public class EquipmentGetRequest : IReturn<EquipmentData>
{
    public int Id { get; set; }
}
