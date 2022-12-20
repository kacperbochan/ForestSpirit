using ServiceStack;

namespace ForestSpirit.ServiceModel.Customers;

[Route("/customer/get/{Id}", "GET")]
public class CustomerGetRequest : IReturn<CustomerData>
{
    public int Id { get; set; }
}
