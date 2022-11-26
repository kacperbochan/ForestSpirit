using ForestSpirit.Framework.Data.Records;
using ForestSpirit.Framework.Orders.Records;
using ForestSpirit.Framework.Orders.Records.Builders;
using System.Data;

namespace ForestSpirit.Framework.Orders.Providers;
public class OrderService : IOrderService
{
    /// <summary>
    /// Połączenie z bazą danych.
    /// </summary>
    private readonly IDbConnection db;

    public OrderService(IDbConnection db)
    {
        this.db = db ?? throw new ArgumentNullException(nameof(db));
    }

    public IOrderRecordBuilder Create()
    {
        var builder = new OrderRecordBuilder(this.db);
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
        return new OrderRecordBuilder(this.db, item);
    }

    public OrderRecord Get(int id)
    {
        if (id <= 0)
        {
            return null;
        }

        // pobranie danych
        var data = this.db.Order().Where(x => x.ID == id);
        var result = this.db.Get(data).FirstOrDefault();
        return result;
    }

    public List<OrderRecord> GetAll()
    {
        // pobranie danych
        var data = this.db.Order();
        return this.db.Get(data);
    }
}
