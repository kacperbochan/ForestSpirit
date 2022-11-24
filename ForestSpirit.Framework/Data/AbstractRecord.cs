using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestSpirit.Framework.Data;
public abstract class AbstractRecord : IRecord
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ChangedDate { get; set; }
    public string CreatedBy { get; set; }
    public string ChangedBy { get; set; }

    /// <inheritdoc />
    public virtual object Clone() => this.Clone();
}
