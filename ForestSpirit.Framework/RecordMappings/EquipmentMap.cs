using FluentNHibernate.Mapping;
using ForestSpirit.Framework.Equipments.Records;

public class EquipmentMap : ClassMap<EquipmentRecord>
{
    public EquipmentMap()
    {
        this.Id(x => x.ID);
        this.Map(x => x.Name);
        this.Map(x => x.SerialNumber);
        this.References(x => x.OutpostId);
    }
}
