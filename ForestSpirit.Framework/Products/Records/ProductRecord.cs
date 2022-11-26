using ForestSpirit.Framework.Data;
using ServiceStack.DataAnnotations;

namespace ForestSpirit.Framework.Products.Records;

[Alias("Product")]
public class ProductRecord : AbstractRecord
{
    [Alias("Name")]
    public virtual string Name { get; set; }

    [Alias("Procentage")]
    public virtual int Procentage { get; set; }

    [Alias("Price")]
    public virtual float Price { get; set; }

    [Alias("Ingridience")]
    public virtual string Ingridience { get; set; }

    [Alias("Rating")]
    public virtual int Rating { get; set; }

    [Alias("Number_Of_Opinions")]
    public virtual int OpinionCount { get; set; }
}
