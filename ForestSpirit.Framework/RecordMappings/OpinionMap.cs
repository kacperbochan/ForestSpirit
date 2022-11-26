using FluentNHibernate.Mapping;
using ForestSpirit.Framework.Opinions.Records;

public class OpinionMap : ClassMap<OpinionRecord>
{
    public OpinionMap()
    {
        this.Id(x => x.ID);
        this.Map(x => x.Text);
        this.Map(x => x.Rating);
        this.References(x => x.CustomerId);
        this.References(x => x.ProductId);
    }
}
