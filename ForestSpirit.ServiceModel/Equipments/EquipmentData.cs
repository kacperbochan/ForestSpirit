using ForestSpirit.ServiceModel.Outposts;
using ServiceStack.DataAnnotations;

namespace ForestSpirit.ServiceModel.Equipments;
public class EquipmentData
{
    public string Name { get; set; }
    public string SerialNumber { get; set; }
    public OutpostData Outpost { get; set; }
}
