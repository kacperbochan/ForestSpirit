using ForestSpirit.Framework.Customers.Records;
using ForestSpirit.Framework.Data;
using ForestSpirit.Framework.Products.Records;
using ServiceStack.DataAnnotations;

namespace ForestSpirit.Framework.Opinions.Records;

[Alias("Opinion")]
public class OpinionRecord : AbstractRecord
{
    [Alias("Text")]
    public virtual string Text { get; set; }

    [Alias("Rating")]
    public virtual int Rating { get; set; }

    [Alias("CustomerId")]
    public virtual int CustomerId { get; set; }

    [Alias("ProductId")]
    public virtual int ProductId { get; set; }

    [Ignore]
    public CustomerRecord Customer { get; set; }

    [Ignore]
    public ProductRecord Product { get; set; }

}
