using ForestSpirit.Framework.Data;
using ForestSpirit.Framework.Equipments.Records;
using ForestSpirit.Framework.Resources.Records;
using ServiceStack.DataAnnotations;

namespace ForestSpirit.Framework.Outposts.Records;

/// <summary>
/// Rekord placówki.
/// </summary>
public class OutpostRecord : AbstractRecord
{
    /// <summary>
    /// Nazwa placówki.
    /// </summary>
    public virtual string Name { get; set; }

    /// <summary>
    /// Szerokośc gerograficzna(y).
    /// </summary>
    public virtual double Latitude { get; set; }

    /// <summary>
    /// Długość gerograficzna(x).
    /// </summary>
    public virtual double Longitude { get; set; }

    /// <summary>
    /// Status placówki.
    /// </summary>
    public virtual OutpostSTRecord State { get; set; }

    /// <summary>
    /// Ekwipunki placówki.
    /// </summary>
    public virtual IList<EquipmentRecord> Equipments { get; set; }

    /// <summary>
    /// Zadoby polacówki.
    /// </summary>
    public virtual IList<ResourceRecord> Resources { get; set; }

    /// <summary>
    /// Produkty placówki.
    /// </summary>
    public virtual IList<OutpostProductRecord> OutpostProducts { get; set; }
}
