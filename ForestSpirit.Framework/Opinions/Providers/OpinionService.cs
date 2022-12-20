using ForestSpirit.Framework.Data.Records;
using ForestSpirit.Framework.Opinions.Records;
using ForestSpirit.Framework.Opinions.Records.Builders;
using NHibernate;
using System.Data;

namespace ForestSpirit.Framework.Opinions.Providers;
public class OpinionService : AbstractService<OpinionRecord>, IOpinionService
{
    public OpinionService(ISessionFactory db)
        : base(db)
    {
    }

    public IOpinionRecordBuilder Create()
    {
        var builder = new OpinionRecordBuilder(this.Db);
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
        return new OpinionRecordBuilder(this.Db, item);
    }
}
