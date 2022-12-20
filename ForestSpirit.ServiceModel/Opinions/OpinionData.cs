using ForestSpirit.ServiceModel.Customers;
using ForestSpirit.ServiceModel.Products;
using ServiceStack.DataAnnotations;

namespace ForestSpirit.ServiceModel.Opinions;
public class OpinionData
{
    public string Text { get; set; }

    public int Rating { get; set; }

    public CustomerData Customer { get; set; }
    public ProductData Product { get; set; }
}
