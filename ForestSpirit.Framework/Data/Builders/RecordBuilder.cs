using ForestSpirit.Framework.Data.Records;
using NHibernate;
using ServiceStack;
using ServiceStack.OrmLite;
using System.Data;
using System.Linq.Expressions;
using System.Text.Json;

namespace ForestSpirit.Framework.Data.Builders;

public abstract class RecordBuilder<TBuilder, TRecord> : IRecordBuilder, IExtendedRecordBuilder<TBuilder, TRecord>
    where TBuilder : IRecordBuilder
    where TRecord : class, ICloneable, new()
{
    public ISessionFactory Db { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="RecordBuilder{TBuilder, TRecord}"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    protected RecordBuilder(ISessionFactory db)
    {
        this.Db = db ?? throw new ArgumentNullException(nameof(db));
        this.Record = new TRecord();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RecordBuilder{TBuilder, TRecord}"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <param name="record">Obiekt rekordu.</param>
    protected RecordBuilder(ISessionFactory db, TRecord record)
    {
        this.Db = db ?? throw new ArgumentNullException(nameof(db));
        this.Record = record ?? throw new ArgumentNullException(nameof(record));
        this.StoreChangeDetection();
    }

    /// <summary>
    /// Skrót obiektu rekordu.
    /// </summary>
    protected int HashCode { get; set; }

    /// <summary>
    /// Rekord danych.
    /// </summary>
    protected TRecord Record { get; }

    /// <summary>
    /// Rekord danych z wartościami przed wykonanymi zmianami.
    /// </summary>
    protected TRecord Previous { get; set; }

    /// <summary>
    /// Kolekcja zmienionych kolumn.
    /// </summary>
    protected HashSet<string> Columns { get; } = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);

    /// <inheritdoc />
    public virtual bool HasChanged() => this.CalculateHash(this.Record) != this.HashCode;

    /// <summary>
    /// Zachowanie detekcji zmian.
    /// </summary>
    protected void StoreChangeDetection()
    {
        this.HashCode = this.CalculateHash(this.Record);
    }

    /// <summary>
    /// Wylicza skrót obiektu.
    /// </summary>
    /// <param name="item">Obiekt do obliczenia skrótu.</param>
    /// <returns>Skrót.</returns>
    protected virtual int CalculateHash(object item)
    {
        if (item == null)
        {
            throw new ArgumentNullException(nameof(item));
        }

        return JsonSerializer.Serialize(item).GetHashCode();
    }

    /// <inheritdoc />
    public abstract TBuilder GetNext();

    /// <inheritdoc />
    public virtual TRecord Peek() => this.Record;

    /// <summary>
    /// Flaga wymuszenia zapisu wszystkich kolumn.
    /// </summary>
    public bool ForceAll { get; set; }

    /// <inheritdoc />
    public virtual TRecord Save()
    {
        if (this.IsNew())
        {
            using (var session = this.Db.OpenSession())
            {
                object id = session.Save(this.Record);
            }
        }
        else if (this.HasChanged())
        {
            bool flag = this.Columns.Count > 0;
            if (flag)
            {
                this.ExecuteUpdate();
            }
        }

        return this.Record;
    }

    /// <summary>
    /// Czy rekord jest nowy.
    /// </summary>
    /// <returns>True jeśli rekord jest nowy (INSERT), False w przypadku aktualizacji (UPDATE).</returns>
    protected virtual bool IsNew()
    {
        if (this.Record is IRecord dataRecord)
        {
            return dataRecord.IsNew();
        }

        return true;
    }

    /// <inheritdoc />
    protected void ExecuteUpdate()
    {
        try
        {
            using (var session = this.Db.OpenSession())
            {
                session.Update(this.Record);
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message); // NIE UŻYWAC Exception
        }
    }
}
