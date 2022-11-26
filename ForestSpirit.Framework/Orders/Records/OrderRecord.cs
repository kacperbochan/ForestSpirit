using ForestSpirit.Framework.Data;
using ServiceStack.DataAnnotations;

namespace ForestSpirit.Framework.Orders.Records;

[Alias("Order")]
public class OrderRecord : AbstractRecord
{
    [Alias("OrderDate")]
    public DateTime OrderDate { get; set; }

    [Alias("CustomerId")]
    public int CustomerId { get; set; }

    [Alias("Price")]
    public float Price { get; set; }

    [Alias("Status")]
    public short Status { get; set; }

    [Alias("PredictedDeliveryDate")]
    public DateTime PredictedDeliveryDate { get; set; }
}
