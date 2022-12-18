using ServiceStack;

namespace ForestSpirit.ServiceModel.Products;

public class ProductCreateRequest
{
    public string Name { get; set; }

    public int Procentage { get; set; }

    public float Price { get; set; }
}
