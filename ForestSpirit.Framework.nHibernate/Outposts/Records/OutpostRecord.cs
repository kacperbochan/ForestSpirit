using ForestSpirit.Framework.Data;

using ServiceStack.DataAnnotations;

namespace ForestSpirit.Framework.Outposts.Records;

[Alias("Outpost")]
public class OutpostRecord : AbstractRecord
{
    [Alias("Text")]
    public string Name { get; set; }

    [Alias("Rating")]
    public double Latitude { get; set; }

    [Alias("CustomerId")]
    public double Longitude { get; set; }
}
