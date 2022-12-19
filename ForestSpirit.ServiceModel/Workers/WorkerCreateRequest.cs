using ServiceStack;

namespace ForestSpirit.ServiceModel.Workers;

[Route("/worker/create", "POST")]
public class WorkerCreateRequest : IReturn<WorkerData>
{
    public string Name { get; set; }

    public float Wage { get; set; }

    public short Type { get; set; }

    public short Status { get; set; }
}
