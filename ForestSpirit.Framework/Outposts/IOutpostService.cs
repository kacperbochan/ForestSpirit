using ForestSpirit.Framework.Outposts.Records;
using ForestSpirit.Framework.Data;
using ForestSpirit.Framework.Outposts.Records.Builders;

namespace ForestSpirit.Framework.Outposts;
public interface IOutpostService : IBuildableService<IOutpostRecordBuilder, OutpostRecord>
{
    List<OutpostRecord> GetAll();
    OutpostRecord Get(int id);
}
