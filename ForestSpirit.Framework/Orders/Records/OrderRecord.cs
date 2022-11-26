using ForestSpirit.Framework.Customers.Records;
using ForestSpirit.Framework.Data;
using ServiceStack.DataAnnotations;

namespace ForestSpirit.Framework.Orders.Records;

[Alias("Order")]
public class OrderRecord : AbstractRecord
{
    [Alias("OrderDate")]
    public virtual DateTime OrderDate { get; set; }

    [Alias("CustomerId")]
    public virtual int CustomerId { get; set; }

    [Alias("Price")]
    public virtual float Price { get; set; }

    [Alias("Status")]
    public virtual short Status { get; set; }

    [Alias("PredictedDeliveryDate")]
    public virtual DateTime PredictedDeliveryDate { get; set; }

    [Ignore]
    public CustomerRecord Customer { get; set; }
}
