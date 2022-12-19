using ServiceStack.DataAnnotations;

namespace ForestSpirit.ServiceModel.Products;
public class ProductData
{
    public string Name { get; set; }

    public int Procentage { get; set; }

    public float Price { get; set; }

    public string Ingridience { get; set; }

    public int Rating { get; set; }

    public int OpinionCount { get; set; }
}
