using ForestSpirit.Framework.Data;
using ForestSpirit.Framework.Opinions.Records;
using ForestSpirit.Framework.Outposts.Records;
using ServiceStack.DataAnnotations;

namespace ForestSpirit.Framework.Products.Records;

/// <summary>
/// Rekord porduktu.
/// </summary>
public class ProductRecord : AbstractRecord
{
    /// <summary>
    /// Id.
    /// </summary>
    public virtual int Id { get; set; }

    /// <summary>
    /// Nazwa.
    /// </summary>
    public virtual string Name { get; set; }

    /// <summary>
    /// Procent alkocholu w produkcie.
    /// </summary>
    public virtual int Procentage { get; set; }

    /// <summary>
    /// Cena produktu.
    /// </summary>
    public virtual float Price { get; set; }

    /// <summary>
    /// Skłądniki.
    /// </summary>
    public virtual string Ingridience { get; set; }

    /// <summary>
    /// Ocena.
    /// </summary>
    public virtual int Rating { get; set; }

    /// <summary>
    /// Ilość opinii.
    /// </summary>
    public virtual int OpinionCount { get; set; }

    /// <summary>
    /// Lista przypisań produktu do placówki.
    /// </summary>
    public virtual IList<OutpostProductRecord> OutpostProducts { get; set; }

    /// <summary>
    /// List opinii.
    /// </summary>
    public virtual IList<OpinionRecord> Opinions { get; set; }
}
