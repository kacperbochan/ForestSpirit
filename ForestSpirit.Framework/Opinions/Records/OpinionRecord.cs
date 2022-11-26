using ForestSpirit.Framework.Data;

using ServiceStack.DataAnnotations;

namespace ForestSpirit.Framework.Opinions.Records;

[Alias("Opinion")]
public class OpinionRecord : AbstractRecord
{
    [Alias("Text")]
    public string Text { get; set; }

    [Alias("Rating")]
    public int Rating { get; set; }

    [Alias("CustomerId")]
    public int CustomerId { get; set; }

    [Alias("ProductId")]
    public int ProductId { get; set; }
}
