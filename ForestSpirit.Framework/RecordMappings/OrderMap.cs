using FluentNHibernate.Mapping;
using ForestSpirit.Framework.Orders.Records;

public class OrderMap : ClassMap<OrderRecord>
{
    public OrderMap()
    {
        this.Table("Order");
        this.Id(x => x.Id);
        this.Map(x => x.OrderDate);
        this.References(x => x.CustomerId);
        this.Map(x => x.Price);
        this.Map(x => x.Status);
        this.Map(x => x.PredictedDeliveryDate);
        this.Map(x => x.ChangedBy).Column("Changed_By");
        this.Map(x => x.ChangedDate).Column("Changed_At");
        this.Map(x => x.CreatedBy).Column("Created_By");
        this.Map(x => x.CreatedDate).Column("Created_At");
    }
}
