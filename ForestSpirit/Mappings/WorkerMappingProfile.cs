using AutoMapper;
using ForestSpirit.Framework.Products.Records;
using ForestSpirit.ServiceModel.Workers;

namespace ForestSpirit.Mappings;

public class WorkerMappingProfile : Profile
{
    public WorkerMappingProfile()
    {
        this.CreateMap<WorkerRecord, WorkerData>();
    }
}
