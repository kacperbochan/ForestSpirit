using ForestSpirit.Framework.Data.Builders;
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
        throw new NotImplementedException();
    }

    public IEquipmentRecordBuilder OutpostId(int value)
    {
        throw new NotImplementedException();
    }

    public IEquipmentRecordBuilder SerialNumber(string value)
    {
        throw new NotImplementedException();
    }
}
