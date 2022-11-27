using ForestSpirit.Framework.Data;
using ForestSpirit.Framework.Opinions.Records;
using ForestSpirit.Framework.Orders.Records;

namespace ForestSpirit.Framework.Customers.Records;

/// <summary>
/// Rekord klienta.
/// </summary>
public class CustomerRecord : AbstractRecord
{
    /// <summary>
    /// Nazwa klienta.
    /// </summary>
    public virtual string Name { get; set; }

    /// <summary>
    /// Publiczna nazwa klienta.
    /// </summary>
    public virtual string PublicName { get; set; }

    /// <summary>
    /// Lista zlaceń klienta.
    /// </summary>
    public virtual IList<OrderRecord> Order { get; set; }

    /// <summary>
    /// Lista opini zostawionych przez klienta.
    /// </summary>
    public virtual IList<OpinionRecord> Opinion { get; set; }
}