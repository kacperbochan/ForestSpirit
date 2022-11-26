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

    public IOrderRecordBuilder CustomerId(int value)
    {
        throw new NotImplementedException();
    }

    public override IOrderRecordBuilder GetNext() => this;

    public IOrderRecordBuilder OrderDate(DateTime value)
    {
        throw new NotImplementedException();
    }

    public IOrderRecordBuilder PredictedDeliveryDate(DateTime value)
    {
        throw new NotImplementedException();
    }

    public IOrderRecordBuilder Price(float value)
    {
        throw new NotImplementedException();
    }

    public IOrderRecordBuilder Status(short value)
    {
        throw new NotImplementedException();
    }
}
