using FluentNHibernate.Mapping;
using ForestSpirit.Framework.Resources.Records;

/// <summary>
/// Mapowanie rekordu zasobu placówki.
/// </summary>
public class ResourceMap : ClassMap<ResourceRecord>
{
    public ResourceMap()
    {
        this.Table("Resources");
        this.Id(x => x.Id);
        this.Map(x => x.Name);
        this.Map(x => x.Quantity);
        this.Map(x => x.ExpirationDate);
        this.Map(x => x.BuyDate);
        this.Map(x => x.ChangedBy).Column("Changed_By");
        this.Map(x => x.ChangedDate).Column("Changed_At");
        this.Map(x => x.CreatedBy).Column("Created_By");
        this.Map(x => x.CreatedDate).Column("Created_At");
        this.References(x => x.Outpost)
            .Column("OutpostID")
            .Cascade.All();
    }
}
