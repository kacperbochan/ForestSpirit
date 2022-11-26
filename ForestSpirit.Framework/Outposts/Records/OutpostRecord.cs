using ForestSpirit.Framework.Data;

using ServiceStack.DataAnnotations;

namespace ForestSpirit.Framework.Outposts.Records;

[Alias("Outpost")]
public class OutpostRecord : AbstractRecord
{
    [Alias("Text")]
    public virtual string Name { get; set; }

    [Alias("Rating")]
    public virtual double Latitude { get; set; }

    [Alias("CustomerId")]
    public virtual double Longitude { get; set; }
}
