using ForestSpirit.Framework.Data.Records;
using ForestSpirit.Framework.Customers.Records;
using ForestSpirit.Framework.Customers.Records.Builders;
using System.Data;

namespace ForestSpirit.Framework.Customers.Providers;
public class CustomerService : ICustomerService
{
    /// <summary>
    /// Połączenie z bazą danych.
    /// </summary>
    private readonly IDbConnection db;

    public CustomerService(IDbConnection db)
    {
        this.db = db ?? throw new ArgumentNullException(nameof(db));
    }

    public ICustomerRecordBuilder Create()
    {
        var builder = new CustomerRecordBuilder(this.db);
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
        return new CustomerRecordBuilder(this.db, item);
    }

    public CustomerRecord Get(int id)
    {
        if (id <= 0)
        {
            return null;
        }

        // pobranie danych
        var data = this.db.Customer().Where(x => x.Id == id);
        var result = this.db.Get(data).FirstOrDefault();
        return result;
    }

    public CustomerRecord Get(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return null;
        }

        // pobranie danych
        var data = this.db.Customer().Where(x => x.Name == name);
        var result = this.db.Get(data).FirstOrDefault();
        return result;
    }

    public List<CustomerRecord> GetAll()
    {
        // pobranie danych
        var data = this.db.Customer();
        return this.db.Get(data);
    }
}
