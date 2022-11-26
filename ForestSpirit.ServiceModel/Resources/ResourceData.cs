using ForestSpirit.ServiceModel.Outposts;
using ServiceStack.DataAnnotations;

namespace ForestSpirit.ServiceModel.Resources;
public class ResourceData
{
    public string Name { get; set; }

    public int Quantity { get; set; }

    public DateTime ExpirationDate { get; set; }

    public DateTime BuyDate { get; set; }

    public OutpostData Outpost { get; set; }
}
