using FluentNHibernate.Mapping;
using ForestSpirit.Framework.Customers.Records;

public class CustomerMap : ClassMap<CustomerRecord>
{
    public CustomerMap()
    {
        this.Id(x => x.ID);
        this.Map(x => x.Name);
        this.Map(x => x.PublicName);
    }
}
