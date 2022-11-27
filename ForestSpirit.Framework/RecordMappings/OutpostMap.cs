using FluentNHibernate.Mapping;
using ForestSpirit.Framework.Outposts.Records;

public class OutpostMap : ClassMap<OutpostRecord>
{
    public OutpostMap()
    {
        this.Table("Outpost");
        this.Id(x => x.Id);
        this.Map(x => x.Name);
        this.Map(x => x.Latitude);
        this.Map(x => x.Longitude);
        this.Map(x => x.ChangedBy).Column("Changed_By");
        this.Map(x => x.ChangedDate).Column("Changed_At");
        this.Map(x => x.CreatedBy).Column("Created_By");
        this.Map(x => x.CreatedDate).Column("Created_At");
    }
}
