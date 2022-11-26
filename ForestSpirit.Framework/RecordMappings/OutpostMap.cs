using FluentNHibernate.Mapping;
using ForestSpirit.Framework.Outposts.Records;

public class OutpostMap : ClassMap<OutpostRecord>
{
    public OutpostMap()
    {
        this.Id(x => x.ID);
        this.Map(x => x.Name);
        this.Map(x => x.Latitude);
        this.Map(x => x.Longitude);
    }
}
