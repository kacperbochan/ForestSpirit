using AutoMapper;
using ForestSpirit.Framework.Opinions.Records;
using ForestSpirit.ServiceModel.Opinions;

namespace ForestSpirit.Mappings;

public class OpinionMappingProfile : Profile
{
    public OpinionMappingProfile()
    {
        this.CreateMap<OpinionRecord, OpinionData>();
    }
}
