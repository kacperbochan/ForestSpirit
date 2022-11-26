using ForestSpirit.Framework.Orders.Records;
using ForestSpirit.Framework.Data;
using ForestSpirit.Framework.Orders.Records.Builders;

namespace ForestSpirit.Framework.Orders;
public interface IOrderService : IBuildableService<IOrderRecordBuilder, OrderRecord>
{
    List<OrderRecord> GetAll();
    OrderRecord Get(int id);
}
