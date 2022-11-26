using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ServiceStack;

namespace ForestSpirit.ServiceModel.Products;

[Route("/products/create", "POST")]
public class ProductCreateRequest
{
    public string Name { get; set; }

    public int Procentage { get; set; }

    public float Price { get; set; }
}
