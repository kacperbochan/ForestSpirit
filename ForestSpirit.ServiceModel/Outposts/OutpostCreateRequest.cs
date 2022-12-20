using ServiceStack;

namespace ForestSpirit.ServiceModel.Outposts;

[Route("/outpost/create", "POST")]
public class OutpostCreateRequest : IReturn<OutpostData>
{
    public string Name { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }
}
