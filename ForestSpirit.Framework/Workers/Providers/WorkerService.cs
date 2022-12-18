using ForestSpirit.Framework.Data.Records;
using ForestSpirit.Framework.Products.Records;
using ForestSpirit.Framework.Workers.Records;
using ForestSpirit.Framework.Workers.Records.Builders;
using NHibernate;
using System.Data;

namespace ForestSpirit.Framework.Workers.Providers;
public class WorkerService : AbstractService<WorkerRecord>, IWorkerService
{

    public WorkerService(ISessionFactory db) : base(db)
    {
    }

    public IWorkerRecordBuilder Create()
    {
        var builder = new WorkerRecordBuilder(this.Db);
        DateTime timestamp = DateTime.UtcNow;
        return builder.CreatedAt(timestamp).CreatedBy("SYSTEM").ChangedAt(timestamp).ChangedBy("SYSTEM");
    }

    public WorkerRecord Save(IWorkerRecordBuilder builder)
    {
        WorkerRecord record;
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

    public IWorkerRecordBuilder Update(WorkerRecord item)
    {
        return new WorkerRecordBuilder(this.Db, item);
    }

    public WorkerRecord Get(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return null;
        }

        // pobranie danych
        using (var session = this.Db.OpenSession())
        {
            return session.Query<WorkerRecord>().Where(x => x.Name == name).FirstOrDefault();
        }
    }
}
