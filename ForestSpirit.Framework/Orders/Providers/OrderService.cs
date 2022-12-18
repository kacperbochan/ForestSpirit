using ForestSpirit.Framework.Data.Records;
using ForestSpirit.Framework.Orders.Records;
using ForestSpirit.Framework.Orders.Records.Builders;
using NHibernate;
using System.Data;

namespace ForestSpirit.Framework.Orders.Providers;
public class OrderService : AbstractService<OrderRecord>, IOrderService
{
    public OrderService(ISessionFactory db)
        : base(db)
    {
    }

    public IOrderRecordBuilder Create()
    {
        var builder = new OrderRecordBuilder(this.Db);
        DateTime timestamp = DateTime.UtcNow;
        return builder.CreatedAt(timestamp).CreatedBy("SYSTEM").ChangedAt(timestamp).ChangedBy("SYSTEM");
    }

    public OrderRecord Save(IOrderRecordBuilder builder)
    {
        OrderRecord record;
        if (builder == null)
        {
            throw new ArgumentNullException(nameof(builder));
        }

        // Jezeli rekord jest nowy.
        if (builder.Peek().IsNew())
        {
            record = builder.Save();
        }
        else
        {
            // aktualizacja nastepuje tylko jesli dokonano jakichs zmian
            if (builder.HasChanged())
            {
                builder.ChangedBy("SYSTEM")
                   .ChangedAt(DateTime.Now);
            }

            record = builder.Save();
        }

        return record;
    }

    public IOrderRecordBuilder Update(OrderRecord item)
    {
        return new OrderRecordBuilder(this.Db, item);
    }
}
