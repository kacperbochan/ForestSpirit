using ForestSpirit.Framework.Data.Records;
using ForestSpirit.Framework.Equipments.Records;
using ForestSpirit.Framework.Equipments.Records.Builders;
using System.Data;

namespace ForestSpirit.Framework.Equipments.Providers;
public class EquipmentService : IEquipmentService
{
    /// <summary>
    /// Połączenie z bazą danych.
    /// </summary>
    private readonly IDbConnection db;

    public EquipmentService(IDbConnection db)
    {
        this.db = db ?? throw new ArgumentNullException(nameof(db));
    }

    public IEquipmentRecordBuilder Create()
    {
        var builder = new EquipmentRecordBuilder(this.db);
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
        return new EquipmentRecordBuilder(this.db, item);
    }

    public EquipmentRecord Get(int id)
    {
        if (id <= 0)
        {
            return null;
        }

        // pobranie danych
        var data = this.db.Equipment().Where(x => x.Id == id);
        var result = this.db.Get(data).FirstOrDefault();
        return result;
    }

    public EquipmentRecord Get(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return null;
        }

        // pobranie danych
        var data = this.db.Equipment().Where(x => x.Name == name);
        var result = this.db.Get(data).FirstOrDefault();
        return result;
    }

    public List<EquipmentRecord> GetAll()
    {
        // pobranie danych
        var data = this.db.Equipment();
        return this.db.Get(data);
    }
}
