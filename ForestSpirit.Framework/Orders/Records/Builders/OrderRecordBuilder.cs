using ForestSpirit.Framework.Customers.Records;
using ForestSpirit.Framework.Data.Builders;

using System.Data;

namespace ForestSpirit.Framework.Orders.Records.Builders;
public class OrderRecordBuilder : AbstractRecordBuilder<IOrderRecordBuilder, OrderRecord>, IOrderRecordBuilder
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OrderRecordBuilder"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    public OrderRecordBuilder(IDbConnection db)
        : base(db)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="OrderRecordBuilder"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <param name="record">Rekord danych.</param>
    public OrderRecordBuilder(IDbConnection db, OrderRecord record)
        : base(db, record)
    {
    }

    public IOrderRecordBuilder Customer(CustomerRecord value)
    {
        this.Record.Customer = value;
        this.Record.CustomerId = value.Id;
        return this.GetNext();
    }

    public override IOrderRecordBuilder GetNext() => this;

    public IOrderRecordBuilder OrderDate(DateTime value)
    {
        this.Record.OrderDate = value;
        return this.GetNext();
    }

    public IOrderRecordBuilder PredictedDeliveryDate(DateTime value)
    {
        this.Record.PredictedDeliveryDate = value;
        return this.GetNext();
    }

    public IOrderRecordBuilder Price(float value)
    {
        this.Record.Price = value;
        return this.GetNext();
    }

    public IOrderRecordBuilder Status(short value)
    {
        this.Record.Status = value;
        return this.GetNext();
    }
}
