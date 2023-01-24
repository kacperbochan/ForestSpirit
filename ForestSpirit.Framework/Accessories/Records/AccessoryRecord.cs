using ForestSpirit.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestSpirit.Framework.Accessories.Records;
public class AccessoryRecord: AbstractRecord
{
    public virtual string Name { get; set; }
    public virtual string Description { get; set; }
    public virtual string Price { get; set; }
}
