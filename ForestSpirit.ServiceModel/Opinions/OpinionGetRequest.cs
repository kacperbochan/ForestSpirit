using ServiceStack;

namespace ForestSpirit.ServiceModel.Opinions;

[Route("/opinion/get/{Id}", "GET")]
public class OpinionGetRequest : IReturn<OpinionData>
{
    public int Id { get; set; }
}
