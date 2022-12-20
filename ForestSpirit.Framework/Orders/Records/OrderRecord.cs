using ForestSpirit.Framework.Customers.Records;
using ForestSpirit.Framework.Data;

namespace ForestSpirit.Framework.Orders.Records;

/// <summary>
/// Rekord zamówienia.
/// </summary>
public class OrderRecord : AbstractRecord
{
    /// <summary>
    /// Data złożenia zamówienia.
    /// </summary>
    public virtual DateTime OrderDate { get; set; }

    /// <summary>
    /// Identyfikator klienta.
    /// </summary>
    public virtual int CustomerId { get; set; }

    /// <summary>
    /// Cena.
    /// </summary>
    public virtual float Price { get; set; }

    /// <summary>
    /// Status zamówienia.
    /// </summary>
    public virtual short Status { get; set; }

    /// <summary>
    /// Przewidziana data dostawy.
    /// </summary>
    public virtual DateTime PredictedDeliveryDate { get; set; }

    /// <summary>
    /// Klient który złożył zamówienie.
    /// </summary>
    public virtual CustomerRecord Customer { get; set; }

    /// <summary>
    /// Lista obiektów zamówień podpiętych do zamówienia.
    /// </summary>
    public virtual IList<OrderItemRecord> OrderItems { get; set; }
}
