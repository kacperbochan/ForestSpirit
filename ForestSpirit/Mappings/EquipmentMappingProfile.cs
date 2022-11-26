using AutoMapper;
using ForestSpirit.Framework.Equipments.Records;
using ForestSpirit.ServiceModel.Equipments;

namespace ForestSpirit.Mappings;

public class EquipmentMappingProfile : Profile
{
    public EquipmentMappingProfile()
    {
        this.CreateMap<EquipmentRecord, EquipmentData>();
    }
}
