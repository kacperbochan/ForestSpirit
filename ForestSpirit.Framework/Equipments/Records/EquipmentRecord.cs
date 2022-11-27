using ForestSpirit.Framework.Data;
using ForestSpirit.Framework.Outposts.Records;

namespace ForestSpirit.Framework.Equipments.Records;

/// <summary>
/// Rekord ekwipunku.
/// </summary>
public class EquipmentRecord : AbstractRecord
{
    /// <summary>
    /// Nazwa ekwipunku.
    /// </summary>
    public virtual string Name { get; set; }

    /// <summary>
    /// Numer seryjny.
    /// </summary>
    public virtual string SerialNumber { get; set; }

    /// <summary>
    /// Identyfikator placówki.
    /// </summary>
    public virtual int OutpostId { get; set; }

    /// <summary>
    /// Placówka.
    /// </summary>
    public virtual OutpostRecord Outpost { get; set; }
}