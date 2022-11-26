using ForestSpirit.Framework.Data;
using ServiceStack.DataAnnotations;

namespace ForestSpirit.Framework.Customers.Records;

[Alias("Customer")]
public class CustomerRecord : AbstractRecord
{
    [Alias("Name")]
    public virtual string Name { get; set; }

    [Alias("PublicName")]
    public virtual string PublicName { get; set; }
}
