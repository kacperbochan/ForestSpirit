using FluentNHibernate.Mapping;
using ForestSpirit.Framework.Outposts.Records;

/// <summary>
/// Mapowanie rekordu statusu placówki.
/// </summary>
public class OutpostSTMap : ClassMap<OutpostSTRecord>
{
    public OutpostSTMap()
    {
        this.Table("Outpost_ST");
        this.Id(x => x.Id);
        this.Map(x => x.OrderCount);
        this.Map(x => x.ChangedBy).Column("Changed_By");
        this.Map(x => x.ChangedDate).Column("Changed_At");
        this.Map(x => x.CreatedBy).Column("Created_By");
        this.Map(x => x.CreatedDate).Column("Created_At");
        this.References(x => x.Outpost, "OutpostId").Unique();
    }
}
