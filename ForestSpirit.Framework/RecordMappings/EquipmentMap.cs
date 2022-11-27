using FluentNHibernate.Mapping;
using ForestSpirit.Framework.Equipments.Records;

/// <summary>
/// Mapowanie rekordu ekwipunku.
/// </summary>
public class EquipmentMap : ClassMap<EquipmentRecord>
{
    public EquipmentMap()
    {
        this.Table("Equipment");
        this.Id(x => x.Id);
        this.Map(x => x.Name);
        this.Map(x => x.SerialNumber);
        this.Map(x => x.ChangedBy).Column("Changed_By");
        this.Map(x => x.ChangedDate).Column("Changed_At");
        this.Map(x => x.CreatedBy).Column("Created_By");
        this.Map(x => x.CreatedDate).Column("Created_At");
        this.References(x => x.Outpost)
            .Column("OutpostID")
            .Cascade.All();
    }
}
