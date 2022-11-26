using ForestSpirit.Framework.Data.Builders;
using ForestSpirit.Framework.Outposts.Records;
using System.Data;

namespace ForestSpirit.Framework.Equipments.Records.Builders;
public class EquipmentRecordBuilder : AbstractRecordBuilder<IEquipmentRecordBuilder, EquipmentRecord>, IEquipmentRecordBuilder
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EquipmentRecordBuilder"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    public EquipmentRecordBuilder(IDbConnection db)
        : base(db)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EquipmentRecordBuilder"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <param name="record">Rekord danych.</param>
    public EquipmentRecordBuilder(IDbConnection db, EquipmentRecord record)
        : base(db, record)
    {
    }

    public override IEquipmentRecordBuilder GetNext() => this;

    public IEquipmentRecordBuilder Name(string value)
    {
        this.Record.Name = value;
        return this.GetNext();
    }

    public IEquipmentRecordBuilder Outpost(OutpostRecord value)
    {
        this.Record.Outpost = value;
        this.Record.OutpostId = value.ID;
        return this.GetNext();
    }

    public IEquipmentRecordBuilder SerialNumber(string value)
    {
        this.Record.SerialNumber = value;
        return this.GetNext();
    }
}
