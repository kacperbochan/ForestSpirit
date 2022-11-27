using ForestSpirit.Framework.Data;

namespace ForestSpirit.Framework.Outposts.Records;

/// <summary>
/// Rekord statusu placówki.
/// </summary>
public class OutpostSTRecord : AbstractRecord
{
    /// <summary>
    /// Identyfikator placówki.
    /// </summary>
    public virtual int OutpostId { get; set; }

    /// <summary>
    /// Ilość zamówień która została złożona od tej placówki.
    /// </summary>
    public virtual int OrderCount { get; set; }

    /// <summary>
    /// Placówka.
    /// </summary>
    public virtual OutpostRecord Outpost { get; set; }
}
