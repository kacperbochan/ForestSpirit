using ForestSpirit.Framework.Data.Builders;
using ForestSpirit.Framework.Outposts.Records;
using System.Data;

namespace ForestSpirit.Framework.Resources.Records.Builders;
public class ResourceRecordBuilder : AbstractRecordBuilder<IResourceRecordBuilder, ResourceRecord>, IResourceRecordBuilder
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ResourceRecordBuilder"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    public ResourceRecordBuilder(IDbConnection db)
        : base(db)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ResourceRecordBuilder"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <param name="record">Rekord danych.</param>
    public ResourceRecordBuilder(IDbConnection db, ResourceRecord record)
        : base(db, record)
    {
    }

    public IResourceRecordBuilder BuyDate(DateTime value)
    {
        this.Record.BuyDate = value;
        return this.GetNext();
    }

    public IResourceRecordBuilder ExpirationDate(DateTime value)
    {
        this.Record.ExpirationDate = value;
        return this.GetNext();
    }

    public override IResourceRecordBuilder GetNext() => this;

    public IResourceRecordBuilder Name(string value)
    {
        this.Record.Name = value;
        return this.GetNext();
    }

    public IResourceRecordBuilder Outpost(OutpostRecord value)
    {
        this.Record.Outpost = value;
        this.Record.OutpostId = value.ID;
        return this.GetNext();
    }

    public IResourceRecordBuilder Quantity(int value)
    {
        this.Record.Quantity = value;
        return this.GetNext();
    }
}
