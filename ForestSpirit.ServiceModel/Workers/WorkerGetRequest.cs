using ServiceStack;

namespace ForestSpirit.ServiceModel.Workers;

[Route("/worker/get/{Id}", "GET")]
public class WorkerGetRequest : IReturn<WorkerData>
{
    public int Id { get; set; }
}
