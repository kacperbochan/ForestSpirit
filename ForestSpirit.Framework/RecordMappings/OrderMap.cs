using FluentNHibernate.Mapping;
using ForestSpirit.Framework.Orders.Records;

/// <summary>
/// Mapowanie rekordu zamówienia.
/// </summary>
public class OrderMap : ClassMap<OrderRecord>
{
    public OrderMap()
    {
        this.Table("Order");
        this.Id(x => x.Id);
        this.Map(x => x.OrderDate);
        this.Map(x => x.Price);
        this.Map(x => x.Status);
        this.Map(x => x.PredictedDeliveryDate).Nullable();
        this.Map(x => x.ChangedBy).Column("Changed_By");
        this.Map(x => x.ChangedDate).Column("Changed_At");
        this.Map(x => x.CreatedBy).Column("Created_By");
        this.Map(x => x.CreatedDate).Column("Created_At");
        this.References(x => x.Customer)
            .Column("CustomerId")
            .Cascade.All();
        this.HasMany(x => x.OrderItems);
    }
}
