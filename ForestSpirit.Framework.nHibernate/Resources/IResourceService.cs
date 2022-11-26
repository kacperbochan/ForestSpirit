using ForestSpirit.Framework.Resources.Records;
using ForestSpirit.Framework.Data;
using ForestSpirit.Framework.Resources.Records.Builders;

namespace ForestSpirit.Framework.Resources;
public interface IResourceService : IBuildableService<IResourceRecordBuilder, ResourceRecord>
{
    List<ResourceRecord> GetAll();
    ResourceRecord Get(int id);
    ResourceRecord Get(string name);
}
