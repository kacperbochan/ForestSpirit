using ServiceStack.DataAnnotations;

namespace ForestSpirit.Framework.Data;

public abstract class AbstractRecord : IRecord
{
    [Alias("Id")]
    public int Id { get; set; }

    [Alias("Created_At")]
    public DateTime CreatedDate { get; set; }

    [Alias("Changed_At")]
    public DateTime ChangedDate { get; set; }

    [Alias("Created_By")]
    public string CreatedBy { get; set; }

    [Alias("Changed_By")]
    public string ChangedBy { get; set; }

    /// <inheritdoc />
    public virtual object Clone() => this.Clone();
}