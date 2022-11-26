using ForestSpirit.Framework.Data;
using ServiceStack.DataAnnotations;

namespace ForestSpirit.Framework.Products.Records;

[Alias("Worker")]
public class WorkerRecord : AbstractRecord
{
    [Alias("Name")]
    public string Name { get; set; }

    [Alias("Wage")]
    public float Wage { get; set; }

    [Alias("Type")]
    public short Type { get; set; }

    [Alias("Status")]
    public short Status { get; set; }
}
