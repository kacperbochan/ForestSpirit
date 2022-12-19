using AutoMapper;
using ForestSpirit.Framework.Outposts.Records;
using ForestSpirit.ServiceModel.Outposts;

namespace ForestSpirit.Mappings;

public class OutpostMappingProfile : Profile
{
    public OutpostMappingProfile()
    {
        this.CreateMap<OutpostRecord, OutpostData>();
    }
}
