using ForestSpirit.Framework.Data.Records;
using ForestSpirit.Framework.Products.Records;
using ForestSpirit.Framework.Requests.Records;
using ForestSpirit.Framework.Requests.Records.Builders;
using NHibernate;
using System.Data;

namespace ForestSpirit.Framework.Requests.Providers;
public class RequestService : AbstractService<RequestRecord>, IRequestService
{

    public RequestService(ISessionFactory db)
        :base(db)
    {
    }

    public IRequestRecordBuilder Create()
    {
        var builder = new RequestRecordBuilder(this.Db);
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
        return new RequestRecordBuilder(this.Db, item);
    }
}
