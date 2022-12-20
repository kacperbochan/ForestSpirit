using ServiceStack;

namespace ForestSpirit.ServiceModel.Customers;

[Route("/customer/get", "GET")]
public class CustomerListRequest : IReturn<CustomerData[]>
{
}
