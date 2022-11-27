using ForestSpirit.Framework.Data;
using ForestSpirit.Framework.Outposts.Records;

namespace ForestSpirit.Framework.Orders.Records;

/// <summary>
/// Rekord łączący zamówienie z produktem placówki.
/// </summary>
public class OrderItemRecord : AbstractRecord
{
    /// <summary>
    /// Ilość.
    /// </summary>
    public virtual int Quantity { get; set; }

    /// <summary>
    /// Identyfikator zamówienia.
    /// </summary>
    public virtual int OrderId { get; set; }

    /// <summary>
    /// Identyfikator produktu placówki.
    /// </summary>
    public virtual float OutpostProductId { get; set; }

    /// <summary>
    /// Rekord łączący produkt z placówką.
    /// </summary>
    public virtual OutpostProductRecord OutpostProduct { get; set; }

    /// <summary>
    /// Zamówienie.
    /// </summary>
    public virtual OrderRecord Order { get; set; }
}
