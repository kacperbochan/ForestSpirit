using ServiceStack;

namespace ForestSpirit.ServiceModel.Outposts;

[Route("/outpost/get", "GET")]
public class OutpostListRequest : IReturn<OutpostData[]>
{
}
