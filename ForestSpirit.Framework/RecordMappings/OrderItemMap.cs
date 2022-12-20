using FluentNHibernate.Mapping;
using ForestSpirit.Framework.Orders.Records;

/// <summary>
/// Mapowanie rekordu łączącego zamówienie z produktem placówki.
/// </summary>
public class OrderItemMap : ClassMap<OrderItemRecord>
{
    ///
    public OrderItemMap()
    {
        this.Table("Order");
        this.Id(x => x.Id);
        this.Map(x => x.Quantity).Nullable();
        this.Map(x => x.ChangedBy).Column("Changed_By");
        this.Map(x => x.ChangedDate).Column("Changed_At");
        this.Map(x => x.CreatedBy).Column("Created_By");
        this.Map(x => x.CreatedDate).Column("Created_At");
        this.References(x => x.Order)
            .Column("OrderId")
            .Cascade.All();
        this.References(x => x.OutpostProduct)
            .Column("OutpostProductId")
            .Cascade.All();
    }
}
