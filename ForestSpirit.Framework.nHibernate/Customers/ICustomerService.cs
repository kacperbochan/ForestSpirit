using ForestSpirit.Framework.Customers.Records;
using ForestSpirit.Framework.Data;
using ForestSpirit.Framework.Customers.Records.Builders;

namespace ForestSpirit.Framework.Customers;
public interface ICustomerService : IBuildableService<ICustomerRecordBuilder, CustomerRecord>
{
    List<CustomerRecord> GetAll();
    CustomerRecord Get(int id);
    CustomerRecord Get(string name);
}
