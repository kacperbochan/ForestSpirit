using ForestSpirit.Framework.Data.Records;
using ServiceStack.OrmLite;
using System.Data;
using System.Linq.Expressions;
using System.Text.Json;

namespace ForestSpirit.Framework.Data.Builders;

public abstract class RecordBuilder<TBuilder, TRecord> : IRecordBuilder, IExtendedRecordBuilder<TBuilder, TRecord>
    where TBuilder : IRecordBuilder
    where TRecord : class, ICloneable, new()
{
    public IDbConnection Db { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="RecordBuilder{TBuilder, TRecord}"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    protected RecordBuilder(IDbConnection db)
    {
        this.Db = db ?? throw new ArgumentNullException(nameof(db));
        this.Record = new TRecord();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RecordBuilder{TBuilder, TRecord}"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <param name="record">Obiekt rekordu.</param>
    protected RecordBuilder(IDbConnection db, TRecord record)
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
            var definition = ModelDefinition<TRecord>.Definition;
            var pk = definition.PrimaryKey;
            bool selectIdentity = pk.AutoIncrement && string.IsNullOrEmpty(pk.Sequence);
            long id = this.Db.Insert(this.Record, selectIdentity);

            // ustawienie PK
            if (pk.AutoIncrement)
            {
                if (this.Record is IRecord record)
                {
                    record.ID = (int)id;
                }
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
    protected int ExecuteUpdate()
    {
        var definition = ModelDefinition<TRecord>.Definition;
        var parameter = Expression.Parameter(typeof(TRecord), "x");
        var body = this.Where(definition, parameter);
        var expression = Expression.Lambda<Func<TRecord, bool>>(body, parameter);
        int updated;

        updated = this.ForceAll
                      ? this.Db.Update(this.Record, expression)
                      : this.Db.UpdateOnlyFields(this.Record, this.Columns.ToArray(), expression);

        if (updated == 0)
        {
            //this.ThrowNotFoundException();
        }

        return updated;
    }

    /// <summary>
    /// Utworzenie warunku WHERE do aktualizacji rekordu.
    /// </summary>
    /// <param name="definition">Definicja mapowania ORM.</param>
    /// <param name="x">Parametr lambda.</param>
    /// <remarks>Podstawowym warunkiem aktualizacji jest porównanie klucza <see cref="IDataRecord{TKey}.Id"/>.</remarks>
    /// <returns>Wyrażenie do aktualizacji rekordu.</returns>
    protected virtual BinaryExpression Where(ModelDefinition definition, ParameterExpression x)
    {
        // utworzenie wyrazenia x => x.Id == @id
        var key = definition.PrimaryKey;
        var member = Expression.Property(x, key.PropertyInfo);
        var right = Expression.Property(Expression.Constant(this.Record), key.PropertyInfo);
        BinaryExpression body = Expression.Equal(member, right);
        return body;
    }
}
