using ForestSpirit.Framework.Data.Builders;
using ForestSpirit.Framework.Products.Records;

using System.Data;

namespace ForestSpirit.Framework.Workers.Records.Builders;
public class WorkerRecordBuilder : AbstractRecordBuilder<IWorkerRecordBuilder, WorkerRecord>, IWorkerRecordBuilder
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkerRecordBuilder"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    public WorkerRecordBuilder(IDbConnection db)
        : base(db)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkerRecordBuilder"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <param name="record">Rekord danych.</param>
    public WorkerRecordBuilder(IDbConnection db, WorkerRecord record)
        : base(db, record)
    {
    }

    public override IWorkerRecordBuilder GetNext() => this;

    public IWorkerRecordBuilder Name(string value)
    {
        this.Record.Name = value;
        return this.GetNext();
    }

    public IWorkerRecordBuilder Status(short value)
    {
        this.Record.Status = value;
        return this.GetNext();
    }

    public IWorkerRecordBuilder Type(short value)
    {
        this.Record.Type = value;
        return this.GetNext();
    }

    public IWorkerRecordBuilder Wage(float value)
    {
        this.Record.Wage = value;
        return this.GetNext();
    }
}
