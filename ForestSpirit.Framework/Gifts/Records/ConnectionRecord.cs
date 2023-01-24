using ForestSpirit.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestSpirit.Framework.Accessories.Records;
internal class ConnectionRecord : AbstractRecord
{
    public virtual int ItemId { get; set; }
    public virtual int ItemType { get; set; }
}
