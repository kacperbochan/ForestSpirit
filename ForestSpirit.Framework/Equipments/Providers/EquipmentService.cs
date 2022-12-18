using ForestSpirit.Framework.Data.Records;
using ForestSpirit.Framework.Equipments.Records;
using ForestSpirit.Framework.Equipments.Records.Builders;
using NHibernate;
using System.Data;

namespace ForestSpirit.Framework.Equipments.Providers;
public class EquipmentService : AbstractService<EquipmentRecord> ,IEquipmentService
{
    public EquipmentService(ISessionFactory db)
        : base(db)
    {
    }

    public IEquipmentRecordBuilder Create()
    {
        var builder = new EquipmentRecordBuilder(this.Db);
        DateTime timestamp = DateTime.UtcNow;
        return builder.CreatedAt(timestamp).CreatedBy("SYSTEM").ChangedAt(timestamp).ChangedBy("SYSTEM");
    }

    public EquipmentRecord Save(IEquipmentRecordBuilder builder)
    {
        EquipmentRecord record;
        if (builder == null)
        {
            throw new ArgumentNullException(nameof(builder));
        }

        // Jezeli rekord jest nowy.
        if (builder.Peek().IsNew())
        {
            record = builder.Save();
        }
        else
        {
            // aktualizacja nastepuje tylko jesli dokonano jakichs zmian
            if (builder.HasChanged())
            {
                builder.ChangedBy("SYSTEM")
                   .ChangedAt(DateTime.Now);
            }

            record = builder.Save();
        }

        return record;
    }

    public IEquipmentRecordBuilder Update(EquipmentRecord item)
    {
        return new EquipmentRecordBuilder(this.Db, item);
    }
}
