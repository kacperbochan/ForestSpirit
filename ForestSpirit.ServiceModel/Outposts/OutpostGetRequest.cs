using ServiceStack;

namespace ForestSpirit.ServiceModel.Outposts;

[Route("/outpost/get/{Id}", "GET")]
public class OutpostGetRequest : IReturn<OutpostData>
{
    public int Id { get; set; }
}
