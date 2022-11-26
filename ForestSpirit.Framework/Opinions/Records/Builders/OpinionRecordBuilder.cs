using ForestSpirit.Framework.Data.Builders;
using System.Data;

namespace ForestSpirit.Framework.Opinions.Records.Builders;
public class OpinionRecordBuilder : AbstractRecordBuilder<IOpinionRecordBuilder, OpinionRecord>, IOpinionRecordBuilder
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OpinionRecordBuilder"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    public OpinionRecordBuilder(IDbConnection db)
        : base(db)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="OpinionRecordBuilder"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <param name="record">Rekord danych.</param>
    public OpinionRecordBuilder(IDbConnection db, OpinionRecord record)
        : base(db, record)
    {
    }

    public IOpinionRecordBuilder CustomerId(int value)
    {
        throw new NotImplementedException();
    }

    public override IOpinionRecordBuilder GetNext() => this;

    public IOpinionRecordBuilder ProductId(int value)
    {
        throw new NotImplementedException();
    }

    public IOpinionRecordBuilder Rating(int value)
    {
        throw new NotImplementedException();
    }

    public IOpinionRecordBuilder Text(string value)
    {
        throw new NotImplementedException();
    }
}
