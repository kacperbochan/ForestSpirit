using ServiceStack;

namespace ForestSpirit.ServiceModel.Products;

[Route("/product/get", "GET")]
public class ProductListRequest : IReturn<ProductData[]>
{
}
