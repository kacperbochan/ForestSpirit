using ServiceStack;
using ServiceStack.DataAnnotations;

namespace ForestSpirit.ServiceModel.Resources;

[Route("/resource/create", "POST")]
public class ResourceCreateRequest : IReturn<ResourceData>
{
    public string Name { get; set; }

    public int Quantity { get; set; }

    public DateTime ExpirationDate { get; set; }

    public DateTime BuyDate { get; set; }

    public int OutpostId { get; set; }
}
