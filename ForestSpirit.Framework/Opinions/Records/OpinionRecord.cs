using ForestSpirit.Framework.Customers.Records;
using ForestSpirit.Framework.Data;
using ForestSpirit.Framework.Products.Records;

namespace ForestSpirit.Framework.Opinions.Records;

/// <summary>
/// Rekord opinii.
/// </summary>
public class OpinionRecord : AbstractRecord
{
    /// <summary>
    /// Treść opinii.
    /// </summary>
    public virtual string Text { get; set; }

    /// <summary>
    /// Ocena.
    /// </summary>
    public virtual int Rating { get; set; }

    /// <summary>
    /// Identyfikator klienta.
    /// </summary>
    public virtual int CustomerId { get; set; }

    /// <summary>
    /// Identyfikator produktu.
    /// </summary>
    public virtual int ProductId { get; set; }

    /// <summary>
    /// Klient który zostawił opinię.
    /// </summary>
    public virtual CustomerRecord Customer { get; set; }

    /// <summary>
    /// Oceniany produkt.
    /// </summary>
    public virtual ProductRecord Product { get; set; }
}