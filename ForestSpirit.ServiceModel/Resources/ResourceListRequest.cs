using ServiceStack;

namespace ForestSpirit.ServiceModel.Resources;

[Route("/resource/get", "GET")]
public class ResourceListRequest : IReturn<ResourceData[]>
{
}
