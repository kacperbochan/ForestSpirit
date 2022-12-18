using ForestSpirit.Framework.Data.Builders;
using NHibernate;
using System.Data;

namespace ForestSpirit.Framework.Products.Records.Builders;
public class ProductRecordBuilder : AbstractRecordBuilder<IProductRecordBuilder, ProductRecord>, IProductRecordBuilder
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductRecordBuilder"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    public ProductRecordBuilder(ISessionFactory db)
        : base(db)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ProductRecordBuilder"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <param name="record">Rekord danych.</param>
    public ProductRecordBuilder(ISessionFactory db, ProductRecord record)
        : base(db, record)
    {
    }

    public override IProductRecordBuilder GetNext() => this;

    public IProductRecordBuilder Ingridience(string value)
    {
        this.Record.Ingridience = value;
        return this.GetNext();
    }

    public IProductRecordBuilder Name(string value)
    {
        this.Record.Name = value;
        return this.GetNext();
    }

    public IProductRecordBuilder OpinionCount(int value)
    {
        this.Record.OpinionCount = value;
        return this.GetNext();
    }

    public IProductRecordBuilder Price(float value)
    {
        this.Record.Price = value;
        return this.GetNext();
    }

    public IProductRecordBuilder Procentage(int value)
    {
        this.Record.Procentage = value;
        return this.GetNext();
    }

    public IProductRecordBuilder Rating(int value)
    {
        this.Record.Rating = value;
        return this.GetNext();
    }
}
