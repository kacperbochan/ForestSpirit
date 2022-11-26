using ForestSpirit.Framework.Data.Builders;
using System.Data;

namespace ForestSpirit.Framework.Outposts.Records.Builders;
public class OutpostRecordBuilder : AbstractRecordBuilder<IOutpostRecordBuilder, OutpostRecord>, IOutpostRecordBuilder
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OutpostRecordBuilder"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    public OutpostRecordBuilder(IDbConnection db)
        : base(db)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="OutpostRecordBuilder"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <param name="record">Rekord danych.</param>
    public OutpostRecordBuilder(IDbConnection db, OutpostRecord record)
        : base(db, record)
    {
    }

    public override IOutpostRecordBuilder GetNext() => this;

    public IOutpostRecordBuilder Latitude(double value)
    {
        this.Record.Latitude = value;
        return this.GetNext();
    }

    public IOutpostRecordBuilder Longitude(double value)
    {
        this.Record.Longitude = value;
        return this.GetNext();
    }

    public IOutpostRecordBuilder Name(string value)
    {
        this.Record.Name = value;
        return this.GetNext();
    }
}
