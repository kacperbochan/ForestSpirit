using ForestSpirit.Framework.Data.Builders;
using System.Data;

namespace ForestSpirit.Framework.Customers.Records.Builders;
public class CustomerRecordBuilder : AbstractRecordBuilder<ICustomerRecordBuilder, CustomerRecord>, ICustomerRecordBuilder
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CustomerRecordBuilder"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    public CustomerRecordBuilder(IDbConnection db)
        : base(db)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CustomerRecordBuilder"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <param name="record">Rekord danych.</param>
    public CustomerRecordBuilder(IDbConnection db, CustomerRecord record)
        : base(db, record)
    {
    }

    public override ICustomerRecordBuilder GetNext() => this;

    public ICustomerRecordBuilder Name(string value)
    {
        this.Record.Name = value;
        return this.GetNext();
    }

    public ICustomerRecordBuilder PublicName(string value)
    {
        this.Record.PublicName = value;
        return this.GetNext();
    }
}
