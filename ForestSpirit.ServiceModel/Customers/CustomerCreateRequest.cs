using ServiceStack;

namespace ForestSpirit.ServiceModel.Customers;

[Route("/customer/create", "POST")]
public class CustomerCreateRequest : IReturn<CustomerData>
{
    public string Name { get; set; }

    public string PublicName { get; set; }
}
