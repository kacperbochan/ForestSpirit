using ServiceStack;

namespace ForestSpirit.ServiceModel.Equipments;

[Route("/equipment/get", "GET")]
public class EquipmentListRequest : IReturn<EquipmentData[]>
{
}
