using NHibernate;
using System.Data;

namespace ForestSpirit.Framework.Data.Builders;
public abstract class AbstractRecordBuilder<TBuilder, TRecord> : RecordBuilder<TBuilder, TRecord>, IAbstractRecordBuilder<TBuilder>
    where TBuilder : IRecordBuilder
    where TRecord : class, IRecord, ICloneable, new()
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AbstractRecordBuilder{TBuilder, TRecord}"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    protected AbstractRecordBuilder(ISessionFactory db)
    : base(db)
    {
        DateTime timestamp = DateTime.Now;
        this.Record.CreatedDate = timestamp;
        this.Record.CreatedBy = BuildInMembers.System;
        this.Record.ChangedDate = timestamp;
        this.Record.ChangedBy = BuildInMembers.System;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="AbstractRecordBuilder{TBuilder, TRecord}"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <param name="record">Obiekt rekordu.</param>
    protected AbstractRecordBuilder(ISessionFactory db, TRecord record)
        : base(db, record)
    {
    }

    /// <inheritdoc />
    public TBuilder Id(int value)
    {
        this.Record.Id = value;
        return this.GetNext();
    }

    /// <inheritdoc />
    public TBuilder CreatedAt(DateTime value)
    {
        this.Record.CreatedDate = value;
        return this.GetNext();
    }

    /// <inheritdoc />
    public TBuilder CreatedBy(string value)
    {
        this.Record.CreatedBy = value ?? throw new ArgumentNullException(nameof(value));
        return this.GetNext();
    }

    /// <inheritdoc />
    public TBuilder ChangedBy(string value)
    {
        this.Record.ChangedBy = value ?? throw new ArgumentNullException(nameof(value));
        return this.GetNext();
    }

    /// <inheritdoc />
    public TBuilder ChangedAt(DateTime value)
    {
        this.Record.ChangedDate = value;
        return this.GetNext();
    }
}