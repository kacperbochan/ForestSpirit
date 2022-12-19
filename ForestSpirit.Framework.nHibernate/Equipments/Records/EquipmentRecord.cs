using ForestSpirit.Framework.Data;
using ForestSpirit.Framework.Outposts.Records;
using ServiceStack.DataAnnotations;

namespace ForestSpirit.Framework.Equipments.Records;

[Alias("Equipment")]
public class EquipmentRecord : AbstractRecord
{
    [Alias("Name")]
    public string Name { get; set; }

    [Alias("SerialNumber")]
    public string SerialNumber { get; set; }

    [Alias("OutpostId")]
    public int OutpostId { get; set; }

    [Ignore]
    public OutpostRecord Outpost { get; set; }
}
