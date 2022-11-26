using FluentNHibernate.Mapping;
using ForestSpirit.Framework.Orders.Records;

public class OrderMap : ClassMap<OrderRecord>
{
    public OrderMap()
    {
        this.Id(x => x.ID);
        this.Map(x => x.OrderDate);
        this.References(x => x.CustomerId);
        this.Map(x => x.Price);
        this.Map(x => x.Status);
        this.Map(x => x.PredictedDeliveryDate);
    }
}
