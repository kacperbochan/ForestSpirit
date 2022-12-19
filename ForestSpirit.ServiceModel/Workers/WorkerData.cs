using ServiceStack.DataAnnotations;

namespace ForestSpirit.ServiceModel.Workers;
public class WorkerData
{
    public string Name { get; set; }

    public float Wage { get; set; }

    public short Type { get; set; }

    public short Status { get; set; }
}
