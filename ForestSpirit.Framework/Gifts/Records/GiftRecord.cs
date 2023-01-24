using ForestSpirit.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestSpirit.Framework.Accessories.Records;
internal class GiftRecord : AbstractRecord
{
    public virtual string Name { get; set; }
    public virtual string Description { get; set; }
    public virtual float OriginalPrice { get; set; }
    public virtual int Discount { get; set; }
    public virtual float Price { get; set; }
}
