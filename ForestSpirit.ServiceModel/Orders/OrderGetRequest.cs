using ServiceStack;

namespace ForestSpirit.ServiceModel.Orders;

[Route("/order/get/{Id}", "GET")]
public class OrderGetRequest : IReturn<OrderData>
{
    public int Id { get; set; }
}
