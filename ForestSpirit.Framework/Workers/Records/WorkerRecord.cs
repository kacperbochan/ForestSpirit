using ForestSpirit.Framework.Data;

namespace ForestSpirit.Framework.Products.Records;

/// <summary>
/// Rekord pracownika.
/// </summary>
public class WorkerRecord : AbstractRecord
{
    /// <summary>
    /// Nazwa pracownika.
    /// </summary>
    public virtual string Name { get; set; }

    /// <summary>
    /// Płaca.
    /// </summary>
    public virtual float Wage { get; set; }

    /// <summary>
    /// Typ.
    /// </summary>
    public virtual short Type { get; set; }

    /// <summary>
    /// Status.
    /// </summary>
    public virtual short Status { get; set; }

    /// <summary>
    /// Zgłoszenia użytkownika.
    /// </summary>
    public virtual IList<RequestRecord> Requests { get; set; }
}
