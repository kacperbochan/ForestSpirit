using ForestSpirit.Framework.Data;
using ForestSpirit.Framework.Orders.Records;
using ForestSpirit.Framework.Products.Records;

namespace ForestSpirit.Framework.Outposts.Records;

/// <summary>
/// Rekord łączący produkt z placówką.
/// </summary>
public class OutpostProductRecord : AbstractRecord
{
    /// <summary>
    /// Data wyprodukowania.
    /// </summary>
    public virtual DateTime ProductionDate { get; set; }

    /// <summary>
    /// Ilość.
    /// </summary>
    public virtual string Quantity { get; set; }

    /// <summary>
    /// Idnetyfikator produktu.
    /// </summary>
    public virtual string ProductID { get; set; }

    /// <summary>
    /// Idnetyfikator placówki.
    /// </summary>
    public virtual string OutpostID { get; set; }

    /// <summary>
    /// Placówka.
    /// </summary>
    public virtual OutpostRecord Outpost { get; set; }

    /// <summary>
    /// Produkt.
    /// </summary>
    public virtual ProductRecord Product { get; set; }

    /// <summary>
    /// Lista rekordów łączących ten produkt z zamówieniem.
    /// </summary>
    public virtual IList<OrderItemRecord> OrderItems { get; set; }
}
