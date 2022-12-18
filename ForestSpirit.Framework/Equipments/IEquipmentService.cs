using ForestSpirit.Framework.Equipments.Records;
using ForestSpirit.Framework.Data;
using ForestSpirit.Framework.Equipments.Records.Builders;

namespace ForestSpirit.Framework.Equipments;
public interface IEquipmentService : IBuildableService<IEquipmentRecordBuilder, EquipmentRecord>
{
    List<EquipmentRecord> GetAll();
    EquipmentRecord Get(int id);
}
