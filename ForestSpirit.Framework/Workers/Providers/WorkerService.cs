using ForestSpirit.Framework.Data.Records;
using ForestSpirit.Framework.Products.Records;
using ForestSpirit.Framework.Workers.Records;
using ForestSpirit.Framework.Workers.Records.Builders;
using System.Data;

namespace ForestSpirit.Framework.Workers.Providers;
public class WorkerService : IWorkerService
{
    /// <summary>
    /// Połączenie z bazą danych.
    /// </summary>
    private readonly IDbConnection db;

    public WorkerService(IDbConnection db)
    {
        this.db = db ?? throw new ArgumentNullException(nameof(db));
    }

    public IWorkerRecordBuilder Create()
    {
        var builder = new WorkerRecordBuilder(this.db);
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
        return new WorkerRecordBuilder(this.db, item);
    }

    public WorkerRecord Get(int id)
    {
        if (id <= 0)
        {
            return null;
        }

        // pobranie danych
        var data = this.db.Worker().Where(x => x.ID == id);
        var result = this.db.Get(data).FirstOrDefault();
        return result;
    }

    public WorkerRecord Get(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return null;
        }

        // pobranie danych
        var data = this.db.Worker().Where(x => x.Name == name);
        var result = this.db.Get(data).FirstOrDefault();
        return result;
    }

    public List<WorkerRecord> GetAll()
    {
        // pobranie danych
        var data = this.db.Worker();
        return this.db.Get(data);
    }
}
