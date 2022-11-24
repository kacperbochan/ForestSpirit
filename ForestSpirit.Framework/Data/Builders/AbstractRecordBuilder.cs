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
    protected AbstractRecordBuilder(IDbConnection db)
            : base(db)
    {
        DateTime timestamp = DateTime.Now;
        Record.CreatedDate = timestamp;
        Record.CreatedBy = BuildInMembers.System;
        Record.ChangedDate = timestamp;
        Record.ChangedBy = BuildInMembers.System;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="AbstractRecordBuilder{TBuilder, TRecord}"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <param name="record">Obiekt rekordu.</param>
    protected AbstractRecordBuilder(IDbConnection db, TRecord record)
        : base(db, record)
    {
    }

    /// <inheritdoc />
    public TBuilder CreatedAt(DateTime value)
    {
        Record.CreatedDate = value;
        return ChangedAt(value);
    }

    /// <inheritdoc />
    public TBuilder CreatedBy(string value)
    {
        Record.CreatedBy = value ?? throw new ArgumentNullException(nameof(value));
        return ChangedBy(value);
    }

    /// <inheritdoc />
    public TBuilder ChangedBy(string value)
    {
        Record.ChangedBy = value ?? throw new ArgumentNullException(nameof(value));
        return GetNext();
    }

    /// <inheritdoc />
    public TBuilder ChangedAt(DateTime value)
    {
        Record.ChangedDate = value;
        return GetNext();
    }
}