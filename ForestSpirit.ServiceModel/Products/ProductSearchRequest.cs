using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestSpirit.ServiceModel.Products;
public class ProductSearchRequest: LimitedReqest
{
    public int[] Keys { get; set; }
    public int[] Category { get; set; }
    public float? HiPrice { get; set; }
    public float? LoPrice { get; set; }
}
