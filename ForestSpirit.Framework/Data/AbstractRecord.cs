using ServiceStack.DataAnnotations;

namespace ForestSpirit.Framework.Data;

public abstract class AbstractRecord : IRecord
{
    [Alias("Id")]
    public virtual int ID { get; set; }

    [Alias("Created_At")]
    public virtual DateTime CreatedDate { get; set; }

    [Alias("Changed_At")]
    public virtual DateTime ChangedDate { get; set; }

    [Alias("Created_By")]
    public virtual string CreatedBy { get; set; }

    [Alias("Changed_By")]
    public virtual string ChangedBy { get; set; }

    /// <inheritdoc />
    public virtual object Clone() => this.Clone();
}