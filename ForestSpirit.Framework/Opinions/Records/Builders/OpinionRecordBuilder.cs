using ForestSpirit.Framework.Customers.Records;
using ForestSpirit.Framework.Data.Builders;
using ForestSpirit.Framework.Products.Records;
using NHibernate;
using System.Data;

namespace ForestSpirit.Framework.Opinions.Records.Builders;
public class OpinionRecordBuilder : AbstractRecordBuilder<IOpinionRecordBuilder, OpinionRecord>, IOpinionRecordBuilder
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OpinionRecordBuilder"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    public OpinionRecordBuilder(ISessionFactory db)
        : base(db)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="OpinionRecordBuilder"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <param name="record">Rekord danych.</param>
    public OpinionRecordBuilder(ISessionFactory db, OpinionRecord record)
        : base(db, record)
    {
    }

    public IOpinionRecordBuilder Customer(CustomerRecord value)
    {
        this.Record.Customer = value;
        this.Record.CustomerId = value.Id;
        return this.GetNext();
    }

    public override IOpinionRecordBuilder GetNext() => this;

    public IOpinionRecordBuilder Product(ProductRecord value)
    {
        this.Record.Product = value;
        this.Record.ProductId = value.Id;
        return this.GetNext();
    }

    public IOpinionRecordBuilder Rating(int value)
    {
        this.Record.Rating = value;
        return this.GetNext();
    }

    public IOpinionRecordBuilder Text(string value)
    {
        this.Record.Text = value;
        return this.GetNext();
    }
}
