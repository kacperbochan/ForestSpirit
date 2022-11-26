using ForestSpirit.Framework.Data.Records;
using ForestSpirit.Framework.Resources.Records;
using ForestSpirit.Framework.Resources.Records.Builders;
using System.Data;

namespace ForestSpirit.Framework.Resources.Providers;
public class ResourceService : IResourceService
{
    /// <summary>
    /// Połączenie z bazą danych.
    /// </summary>
    private readonly IDbConnection db;

    public ResourceService(IDbConnection db)
    {
        this.db = db ?? throw new ArgumentNullException(nameof(db));
    }

    public IResourceRecordBuilder Create()
    {
        var builder = new ResourceRecordBuilder(this.db);
        DateTime timestamp = DateTime.UtcNow;
        return builder.CreatedAt(timestamp).CreatedBy("SYSTEM").ChangedAt(timestamp).ChangedBy("SYSTEM");
    }

    public ResourceRecord Save(IResourceRecordBuilder builder)
    {
        ResourceRecord record;
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

    public IResourceRecordBuilder Update(ResourceRecord item)
    {
        return new ResourceRecordBuilder(this.db, item);
    }

    public ResourceRecord Get(int id)
    {
        if (id <= 0)
        {
            return null;
        }

        // pobranie danych
        var data = this.db.Resources().Where(x => x.ID == id);
        var result = this.db.Get(data).FirstOrDefault();
        return result;
    }

    public ResourceRecord Get(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return null;
        }

        // pobranie danych
        var data = this.db.Resources().Where(x => x.Name == name);
        var result = this.db.Get(data).FirstOrDefault();
        return result;
    }

    public List<ResourceRecord> GetAll()
    {
        // pobranie danych
        var data = this.db.Resources();
        return this.db.Get(data);
    }
}
