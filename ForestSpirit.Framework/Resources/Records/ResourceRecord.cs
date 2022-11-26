using ForestSpirit.Framework.Data;
using ForestSpirit.Framework.Outposts.Records;
using ServiceStack.DataAnnotations;

namespace ForestSpirit.Framework.Resources.Records;

[Alias("Resource")]
public class ResourceRecord : AbstractRecord
{
    [Alias("Name")]
    public virtual string Name { get; set; }

    [Alias("Quantity")]
    public virtual int Quantity { get; set; }

    [Alias("ExpirationDate")]
    public virtual DateTime ExpirationDate { get; set; }

    [Alias("BuyDate")]
    public virtual DateTime BuyDate { get; set; }

    [Alias("OutpostId")]
    public virtual int OutpostId { get; set; }

    [Ignore]
    public OutpostRecord Outpost { get; set; }
}
