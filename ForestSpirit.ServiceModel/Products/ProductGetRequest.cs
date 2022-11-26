using ServiceStack;

namespace ForestSpirit.ServiceModel.Products;

[Route("/product/get/{Id}", "GET")]
public class ProductGetRequest : IReturn<ProductData>
{
    public int Id { get; set; }
}
