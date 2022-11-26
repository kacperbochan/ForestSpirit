using ForestSpirit.Framework.Data;
using ServiceStack.DataAnnotations;

namespace ForestSpirit.Framework.Customers.Records;

[Alias("Customer")]
public class CustomerRecord : AbstractRecord
{
    [Alias("Name")]
    public string Name { get; set; }

    [Alias("PublicName")]
    public string PublicName { get; set; }
}
