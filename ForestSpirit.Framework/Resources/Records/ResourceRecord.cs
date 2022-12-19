using ForestSpirit.Framework.Data;
using ForestSpirit.Framework.Outposts.Records;

namespace ForestSpirit.Framework.Resources.Records;

/// <summary>
/// Rekord zasobu.
/// </summary>
public class ResourceRecord : AbstractRecord
{
    /// <summary>
    /// Nazwa.
    /// </summary>
    public virtual string Name { get; set; }

    /// <summary>
    /// Ilość.
    /// </summary>
    public virtual int Quantity { get; set; }

    /// <summary>
    /// Data przeterminowania.
    /// </summary>
    public virtual DateTime ExpirationDate { get; set; }

    /// <summary>
    /// Data zakupu.
    /// </summary>
    public virtual DateTime BuyDate { get; set; }

    /// <summary>
    /// Identyfikator placówki.
    /// </summary>
    public virtual int OutpostId { get; set; }

    /// <summary>
    /// Placówka.
    /// </summary>
    public virtual OutpostRecord Outpost { get; set; }
}
