using ForestSpirit.Framework.Data.Records;
using ForestSpirit.Framework.Products.Records;
using ForestSpirit.Framework.Requests.Records;
using ForestSpirit.Framework.Requests.Records.Builders;
using System.Data;

namespace ForestSpirit.Framework.Requests.Providers;
public class RequestService : IRequestService
{
    /// <summary>
    /// Połączenie z bazą danych.
    /// </summary>
    private readonly IDbConnection db;

    public RequestService(IDbConnection db)
    {
        this.db = db ?? throw new ArgumentNullException(nameof(db));
    }

    public IRequestRecordBuilder Create()
    {
        var builder = new RequestRecordBuilder(this.db);
        DateTime timestamp = DateTime.UtcNow;
        return builder.CreatedAt(timestamp).CreatedBy("SYSTEM").ChangedAt(timestamp).ChangedBy("SYSTEM");
    }

    public RequestRecord Save(IRequestRecordBuilder builder)
    {
        RequestRecord record;
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

    public IRequestRecordBuilder Update(RequestRecord item)
    {
        return new RequestRecordBuilder(this.db, item);
    }

    public RequestRecord Get(int id)
    {
        if (id <= 0)
        {
            return null;
        }

        // pobranie danych
        var data = this.db.Request().Where(x => x.Id == id);
        var result = this.db.Get(data).FirstOrDefault();
        return result;
    }

    public RequestRecord Get(string Title)
    {
        if (string.IsNullOrEmpty(Title))
        {
            return null;
        }

        // pobranie danych
        var data = this.db.Request().Where(x => x.Title == Title);
        var result = this.db.Get(data).FirstOrDefault();
        return result;
    }

    public List<RequestRecord> GetAll()
    {
        // pobranie danych
        var data = this.db.Request();
        return this.db.Get(data);
    }
}
