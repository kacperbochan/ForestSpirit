using ForestSpirit.Framework.Data.Records;
using ForestSpirit.Framework.Customers.Records;
using ForestSpirit.Framework.Customers.Records.Builders;
using System.Data;
using NHibernate;

namespace ForestSpirit.Framework.Customers.Providers;
public class CustomerService : AbstractService<CustomerRecord>, ICustomerService
{
    public CustomerService(ISessionFactory db)
        : base(db)
    {
    }

    public ICustomerRecordBuilder Create()
    {
        var builder = new CustomerRecordBuilder(this.Db);
        DateTime timestamp = DateTime.UtcNow;
        return builder.CreatedAt(timestamp).CreatedBy("SYSTEM").ChangedAt(timestamp).ChangedBy("SYSTEM");
    }

    public CustomerRecord Save(ICustomerRecordBuilder builder)
    {
        CustomerRecord record;
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

    public ICustomerRecordBuilder Update(CustomerRecord item)
    {
        return new CustomerRecordBuilder(this.Db, item);
    }
}
