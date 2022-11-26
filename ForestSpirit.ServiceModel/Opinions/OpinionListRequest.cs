using ServiceStack;

namespace ForestSpirit.ServiceModel.Opinions;

[Route("/opinion/get", "GET")]
public class OpinionListRequest : IReturn<OpinionData[]>
{
}
