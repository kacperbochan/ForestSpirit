using AutoMapper;
using ForestSpirit.Framework.Resources.Records;
using ForestSpirit.ServiceModel.Resources;

namespace ForestSpirit.Mappings;

public class ResourcesMappingProfile : Profile
{
    public ResourcesMappingProfile()
    {
        this.CreateMap<ResourceRecord, ResourceData>();
    }
}
