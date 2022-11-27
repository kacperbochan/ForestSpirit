using FluentNHibernate.Mapping;
using ForestSpirit.Framework.Opinions.Records;

public class OpinionMap : ClassMap<OpinionRecord>
{
    public OpinionMap()
    {
        this.Table("Opinion");
        this.Id(x => x.Id);
        this.Map(x => x.Text);
        this.Map(x => x.Rating);
        this.References(x => x.CustomerId);
        this.References(x => x.ProductId);
        this.Map(x => x.ChangedBy).Column("Changed_By");
        this.Map(x => x.ChangedDate).Column("Changed_At");
        this.Map(x => x.CreatedBy).Column("Created_By");
        this.Map(x => x.CreatedDate).Column("Created_At");
    }
}
