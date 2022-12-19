using ServiceStack.DataAnnotations;

namespace ForestSpirit.ServiceModel.Outposts;
public class OutpostData
{
    public string Name { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }
}
