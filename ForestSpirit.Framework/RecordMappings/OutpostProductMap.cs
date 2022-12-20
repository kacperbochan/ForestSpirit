using FluentNHibernate.Mapping;
using ForestSpirit.Framework.Outposts.Records;

/// <summary>
/// Mapowanie rekordu łączącego placówkę z produktem.
/// </summary>
public class OutpostProductMap : ClassMap<OutpostProductRecord>
{
    public OutpostProductMap()
    {
        this.Table("Outpost_Product");
        this.Id(x => x.Id);
        this.Map(x => x.ProductionDate);
        this.Map(x => x.Quantity);
        this.Map(x => x.ChangedBy).Column("Changed_By");
        this.Map(x => x.ChangedDate).Column("Changed_At");
        this.Map(x => x.CreatedBy).Column("Created_By");
        this.Map(x => x.CreatedDate).Column("Created_At");
        this.References(x => x.Product)
            .Column("ProductID")
            .Cascade.All();
        this.References(x => x.Outpost)
            .Column("OutpostID")
            .Cascade.All();
        this.HasMany(x => x.OrderItems);
    }
}
