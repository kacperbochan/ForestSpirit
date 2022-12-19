using FluentNHibernate.Mapping;
using ForestSpirit.Framework.Customers.Records;

/// <summary>
/// Mapowanie rekordu klienta.
/// </summary>
public class CustomerMap : ClassMap<CustomerRecord>
{
    public CustomerMap()
    {
        this.Table("Customer");
        this.Id(x => x.Id);
        this.Map(x => x.Name);
        this.Map(x => x.PublicName);
        this.Map(x => x.ChangedBy).Column("Changed_By");
        this.Map(x => x.ChangedDate).Column("Changed_At");
        this.Map(x => x.CreatedBy).Column("Created_By");
        this.Map(x => x.CreatedDate).Column("Created_At");
        this.HasMany(x => x.Order);
        this.HasMany(x => x.Opinion);
    }
}