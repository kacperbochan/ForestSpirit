using ForestSpirit.Framework.Data.Builders;
using ForestSpirit.Framework.Outposts.Records;

namespace ForestSpirit.Framework.Equipments.Records.Builders;
public interface IEquipmentRecordBuilder : IAbstractRecordBuilder<IEquipmentRecordBuilder>,
                                         IExtendedRecordBuilder<IEquipmentRecordBuilder, EquipmentRecord>
{
    IEquipmentRecordBuilder Name(string value);
    IEquipmentRecordBuilder SerialNumber(string value);
    IEquipmentRecordBuilder Outpost(OutpostRecord value);
}
