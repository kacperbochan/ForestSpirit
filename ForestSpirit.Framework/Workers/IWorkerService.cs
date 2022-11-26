using ForestSpirit.Framework.Workers.Records;
using ForestSpirit.Framework.Data;
using ForestSpirit.Framework.Workers.Records.Builders;
using ForestSpirit.Framework.Products.Records;

namespace ForestSpirit.Framework.Workers;
public interface IWorkerService : IBuildableService<IWorkerRecordBuilder, WorkerRecord>
{
    List<WorkerRecord> GetAll();
    WorkerRecord Get(int id);
    WorkerRecord Get(string name);
}
