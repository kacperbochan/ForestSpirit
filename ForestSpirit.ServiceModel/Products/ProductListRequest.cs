using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ServiceStack;

namespace ForestSpirit.ServiceModel.Products;

[Route("/product/get", "GET")]
public class ProductListRequest : IReturn<ProductData[]>
{
}
