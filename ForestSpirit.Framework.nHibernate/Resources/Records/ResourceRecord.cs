using ForestSpirit.Framework.Data;
using ForestSpirit.Framework.Outposts.Records;
using ServiceStack.DataAnnotations;

namespace ForestSpirit.Framework.Resources.Records;

[Alias("Resource")]
public class ResourceRecord : AbstractRecord
{
    [Alias("Name")]
    public string Name { get; set; }

    [Alias("Quantity")]
    public int Quantity { get; set; }

    [Alias("ExpirationDate")]
    public DateTime ExpirationDate { get; set; }

    [Alias("BuyDate")]
    public DateTime BuyDate { get; set; }

    [Alias("OutpostId")]
    public int OutpostId { get; set; }

    [Ignore]
    public OutpostRecord Outpost { get; set; }
}
