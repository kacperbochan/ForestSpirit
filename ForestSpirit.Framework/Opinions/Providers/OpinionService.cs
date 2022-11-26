using ForestSpirit.Framework.Data.Records;
using ForestSpirit.Framework.Opinions.Records;
using ForestSpirit.Framework.Opinions.Records.Builders;
using System.Data;

namespace ForestSpirit.Framework.Opinions.Providers;
public class OpinionService : IOpinionService
{
    /// <summary>
    /// Połączenie z bazą danych.
    /// </summary>
    private readonly IDbConnection db;

    public OpinionService(IDbConnection db)
    {
        this.db = db ?? throw new ArgumentNullException(nameof(db));
    }

    public IOpinionRecordBuilder Create()
    {
        var builder = new OpinionRecordBuilder(this.db);
        DateTime timestamp = DateTime.UtcNow;
        return builder.CreatedAt(timestamp).CreatedBy("SYSTEM").ChangedAt(timestamp).ChangedBy("SYSTEM");
    }

    public OpinionRecord Save(IOpinionRecordBuilder builder)
    {
        OpinionRecord record;
        if (builder == null)
        {
            throw new ArgumentNullException(nameof(builder));
        }

        // Jezeli rekord jest nowy.
        if (builder.Peek().IsNew())
        {
            record = builder.Save();
        }
        else
        {
            // aktualizacja nastepuje tylko jesli dokonano jakichs zmian
            if (builder.HasChanged())
            {
                builder.ChangedBy("SYSTEM")
                   .ChangedAt(DateTime.Now);
            }

            record = builder.Save();
        }

        return record;
    }

    public IOpinionRecordBuilder Update(OpinionRecord item)
    {
        return new OpinionRecordBuilder(this.db, item);
    }

    public OpinionRecord Get(int id)
    {
        if (id <= 0)
        {
            return null;
        }

        // pobranie danych
        var data = this.db.Opinion().Where(x => x.ID == id);
        var result = this.db.Get(data).FirstOrDefault();
        return result;
    }

    public List<OpinionRecord> GetAll()
    {
        // pobranie danych
        var data = this.db.Opinion();
        return this.db.Get(data);
    }
}
