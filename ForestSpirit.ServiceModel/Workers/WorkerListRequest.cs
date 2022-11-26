using ServiceStack;

namespace ForestSpirit.ServiceModel.Workers;

[Route("/worker/get", "GET")]
public class WorkerListRequest : IReturn<WorkerData>
{
}
