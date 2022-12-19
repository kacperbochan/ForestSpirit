using ForestSpirit.Framework.Data;
using ServiceStack.DataAnnotations;

namespace ForestSpirit.Framework.Products.Records;

[Alias("Product")]
public class ProductRecord : AbstractRecord
{
    [Alias("Name")]
    public string Name { get; set; }

    [Alias("Procentage")]
    public int Procentage { get; set; }

    [Alias("Price")]
    public float Price { get; set; }

    [Alias("Ingridience")]
    public string Ingridience { get; set; }

    [Alias("Rating")]
    public int Rating { get; set; }

    [Alias("Number_Of_Opinions")]
    public int OpinionCount { get; set; }
}
