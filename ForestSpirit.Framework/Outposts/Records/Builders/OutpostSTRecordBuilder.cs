using ForestSpirit.Framework.Data.Builders;
using System.Data;

namespace ForestSpirit.Framework.Outposts.Records.Builders;
public class OutpostSTRecordBuilder : AbstractRecordBuilder<IOutpostSTRecordBuilder, OutpostSTRecord>, IOutpostSTRecordBuilder
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OutpostSTRecordBuilder"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    public OutpostSTRecordBuilder(IDbConnection db)
        : base(db)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="OutpostSTRecordBuilder"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <param name="record">Rekord danych.</param>
    public OutpostSTRecordBuilder(IDbConnection db, OutpostSTRecord record)
        : base(db, record)
    {
    }

    public override IOutpostSTRecordBuilder GetNext() => this;

    public IOutpostSTRecordBuilder OrderCount(int value)
    {
        this.Record.OrderCount = value;
        return this.GetNext();
    }
}
