using ForestSpirit.Framework.Data.Builders;
using ForestSpirit.Framework.Products.Records;

using System.Data;

namespace ForestSpirit.Framework.Requests.Records.Builders;
public class RequestRecordBuilder : AbstractRecordBuilder<IRequestRecordBuilder, RequestRecord>, IRequestRecordBuilder
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RequestRecordBuilder"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    public RequestRecordBuilder(IDbConnection db)
        : base(db)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RequestRecordBuilder"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <param name="record">Rekord danych.</param>
    public RequestRecordBuilder(IDbConnection db, RequestRecord record)
        : base(db, record)
    {
    }

    public override IRequestRecordBuilder GetNext() => this;

    public IRequestRecordBuilder Title(string value)
    {
        this.Record.Title = value;
        return this.GetNext();
    }

    public IRequestRecordBuilder Content(string value)
    {
        this.Record.Content = value;
        return this.GetNext();
    }

    public IRequestRecordBuilder Sender(WorkerRecord value)
    {
        this.Record.SenderId = value.Id;
        return this.GetNext();
    }

    public IRequestRecordBuilder Receiver(WorkerRecord value)
    {
        this.Record.ReceiverId = value.Id;
        return this.GetNext();
    }
}
