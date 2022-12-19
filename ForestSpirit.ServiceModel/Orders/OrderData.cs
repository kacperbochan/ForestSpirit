using ForestSpirit.ServiceModel.Customers;
using ServiceStack.DataAnnotations;

namespace ForestSpirit.ServiceModel.Orders;
public class OrderData
{
    public DateTime OrderDate { get; set; }

    public float Price { get; set; }

    public short Status { get; set; }

    public DateTime PredictedDeliveryDate { get; set; }

    public CustomerData Customer { get; set; }
}
