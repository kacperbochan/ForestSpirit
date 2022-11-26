using ForestSpirit.Framework.Data.Builders;

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
        throw new NotImplementedException();
    }

    public IResourceRecordBuilder ExpirationDate(DateTime value)
    {
        throw new NotImplementedException();
    }

    public override IResourceRecordBuilder GetNext() => this;

    public IResourceRecordBuilder Name(string value)
    {
        throw new NotImplementedException();
    }

    public IResourceRecordBuilder OutpostId(int value)
    {
        throw new NotImplementedException();
    }

    public IResourceRecordBuilder Quantity(int value)
    {
        throw new NotImplementedException();
    }
}
