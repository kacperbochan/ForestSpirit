using FluentNHibernate.Mapping;
using ForestSpirit.Framework.Products.Records;

public class ProductMap : ClassMap<ProductRecord>
{
    public ProductMap()
    {
        this.Table("Product");
        this.Id(x => x.Id);
        this.Map(x => x.Name);
        this.Map(x => x.Procentage);
        this.Map(x => x.Price);
        this.Map(x => x.Ingridience);
        this.Map(x => x.Rating);
        this.Map(x => x.OpinionCount).Column("Number_Of_Opinions");
        this.Map(x => x.ChangedBy).Column("Changed_By");
        this.Map(x => x.ChangedDate).Column("Changed_At");
        this.Map(x => x.CreatedBy).Column("Created_By");
        this.Map(x => x.CreatedDate).Column("Created_At");
    }
}
