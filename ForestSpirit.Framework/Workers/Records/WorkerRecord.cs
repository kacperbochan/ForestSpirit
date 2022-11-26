using ForestSpirit.Framework.Data;
using ServiceStack.DataAnnotations;

namespace ForestSpirit.Framework.Products.Records;

[Alias("Worker")]
public class WorkerRecord : AbstractRecord
{
    [Alias("Name")]
    public virtual string Name { get; set; }

    [Alias("Wage")]
    public virtual float Wage { get; set; }

    [Alias("Type")]
    public virtual short Type { get; set; }

    [Alias("Status")]
    public virtual short Status { get; set; }
}
