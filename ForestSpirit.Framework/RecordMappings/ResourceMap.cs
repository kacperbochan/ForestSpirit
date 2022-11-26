using FluentNHibernate.Mapping;
using ForestSpirit.Framework.Resources.Records;

public class ResourceMap : ClassMap<ResourceRecord>
{
    public ResourceMap()
    {
        this.Id(x => x.ID);
        this.Map(x => x.Name);
        this.Map(x => x.Quantity);
        this.Map(x => x.ExpirationDate);
        this.Map(x => x.BuyDate);
        this.Map(x => x.Outpost);
    }
}
