using ServiceStack;

namespace ForestSpirit.ServiceModel.Orders;

[Route("/order/get", "GET")]
public class OrderListRequest : IReturn<OrderData[]>
{
}
