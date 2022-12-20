using ServiceStack;

namespace ForestSpirit.ServiceModel.Orders;

[Route("/order/create", "POST")]
public class OrderCreateRequest : IReturn<OrderData>
{
    public DateTime OrderDate { get; set; }

    public int CustomerId { get; set; }

    public float Price { get; set; }

    public short Status { get; set; }

    public DateTime PredictedDeliveryDate { get; set; }
}
