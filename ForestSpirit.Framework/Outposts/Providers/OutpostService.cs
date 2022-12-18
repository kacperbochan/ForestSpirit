using ForestSpirit.Framework.Data.Records;
using ForestSpirit.Framework.Outposts.Records;
using ForestSpirit.Framework.Outposts.Records.Builders;
using NHibernate;
using System.Data;

namespace ForestSpirit.Framework.Outposts.Providers;
public class OutpostService : AbstractService<OutpostRecord>, IOutpostService
{
    public OutpostService(ISessionFactory db):base(db)
    {
    }

    public IOutpostRecordBuilder Create()
    {
        var builder = new OutpostRecordBuilder(this.Db);
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
        return new OutpostRecordBuilder(this.Db, item);
    }
}
