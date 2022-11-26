using ServiceStack;

namespace ForestSpirit.ServiceModel.Products;

[Route("/products/create", "POST")]
public class ProductCreateRequest : IReturn<ProductData>
{
    public string Name { get; set; }

    public int Procentage { get; set; }

    public float Price { get; set; }
}
