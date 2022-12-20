using ForestSpirit.Framework.Opinions.Records;
using ForestSpirit.Framework.Data;
using ForestSpirit.Framework.Opinions.Records.Builders;

namespace ForestSpirit.Framework.Opinions;
public interface IOpinionService : IBuildableService<IOpinionRecordBuilder, OpinionRecord>
{
    List<OpinionRecord> GetAll();
    OpinionRecord Get(int id);
}
