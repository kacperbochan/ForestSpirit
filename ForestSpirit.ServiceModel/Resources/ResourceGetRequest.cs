using ServiceStack;

namespace ForestSpirit.ServiceModel.Resources;

[Route("/resource/get/{Id}", "GET")]
public class ResourceGetRequest : IReturn<ResourceData>
{
    public int Id { get; set; }
}
