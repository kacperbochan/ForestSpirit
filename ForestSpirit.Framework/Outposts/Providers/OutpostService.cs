using ForestSpirit.Framework.Data.Records;
using ForestSpirit.Framework.Outposts.Records;
using ForestSpirit.Framework.Outposts.Records.Builders;
using System.Data;

namespace ForestSpirit.Framework.Outposts.Providers;
public class OutpostService : IOutpostService
{
    /// <summary>
    /// Połączenie z bazą danych.
    /// </summary>
    private readonly IDbConnection db;

    public OutpostService(IDbConnection db)
    {
        this.db = db ?? throw new ArgumentNullException(nameof(db));
    }

    public IOutpostRecordBuilder Create()
    {
        var builder = new OutpostRecordBuilder(this.db);
        DateTime timestamp = DateTime.UtcNow;
        return builder.CreatedAt(timestamp).CreatedBy("SYSTEM").ChangedAt(timestamp).ChangedBy("SYSTEM");
    }

    public OutpostRecord Save(IOutpostRecordBuilder builder)
    {
        OutpostRecord record;
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

    public IOutpostRecordBuilder Update(OutpostRecord item)
    {
        return new OutpostRecordBuilder(this.db, item);
    }

    public OutpostRecord Get(int id)
    {
        if (id <= 0)
        {
            return null;
        }

        // pobranie danych
        var data = this.db.Outpost().Where(x => x.Id == id);
        var result = this.db.Get(data).FirstOrDefault();
        return result;
    }

    public OutpostRecord Get(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return null;
        }

        // pobranie danych
        var data = this.db.Outpost().Where(x => x.Name == name);
        var result = this.db.Get(data).FirstOrDefault();
        return result;
    }

    public List<OutpostRecord> GetAll()
    {
        // pobranie danych
        var data = this.db.Outpost();
        return this.db.Get(data);
    }
}
