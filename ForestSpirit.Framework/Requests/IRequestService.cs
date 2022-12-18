using ForestSpirit.Framework.Requests.Records;
using ForestSpirit.Framework.Data;
using ForestSpirit.Framework.Requests.Records.Builders;
using ForestSpirit.Framework.Products.Records;

namespace ForestSpirit.Framework.Requests;
public interface IRequestService : IBuildableService<IRequestRecordBuilder, RequestRecord>
{
    List<RequestRecord> GetAll();
    RequestRecord Get(int id);
}
