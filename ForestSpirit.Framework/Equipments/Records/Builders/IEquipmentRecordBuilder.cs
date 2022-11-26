using ForestSpirit.Framework.Data.Builders;

namespace ForestSpirit.Framework.Equipments.Records.Builders;
public interface IEquipmentRecordBuilder : IAbstractRecordBuilder<IEquipmentRecordBuilder>,
                                         IExtendedRecordBuilder<IEquipmentRecordBuilder, EquipmentRecord>
{
    IEquipmentRecordBuilder Name(string value);
    IEquipmentRecordBuilder SerialNumber(string value);
    IEquipmentRecordBuilder OutpostId(int value);
}
