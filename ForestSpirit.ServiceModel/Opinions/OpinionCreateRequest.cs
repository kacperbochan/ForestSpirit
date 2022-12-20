using ServiceStack;
using ServiceStack.DataAnnotations;

namespace ForestSpirit.ServiceModel.Opinions;

[Route("/opinion/create", "POST")]
public class OpinionCreateRequest : IReturn<OpinionData>
{
    public string Text { get; set; }

    public int Rating { get; set; }

    public int CustomerId { get; set; }

    public int ProductId { get; set; }
}
