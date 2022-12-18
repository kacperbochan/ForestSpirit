using ForestSpirit.Framework.Data.Records;
using ForestSpirit.Framework.Resources.Records;
using ForestSpirit.Framework.Resources.Records.Builders;
using NHibernate;
using System.Data;

namespace ForestSpirit.Framework.Resources.Providers;
public class ResourceService : AbstractService<ResourceRecord>, IResourceService
{ 
    public ResourceService(ISessionFactory db):base(db)
    {
    }

    public IResourceRecordBuilder Create()
    {
        var builder = new ResourceRecordBuilder(this.Db);
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
        return new ResourceRecordBuilder(this.Db, item);
    }

}
