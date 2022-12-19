using AutoMapper;
using ForestSpirit.Framework.Customers.Records;
using ForestSpirit.ServiceModel.Customers;

namespace ForestSpirit.Mappings;

public class CustomerMappingProfile : Profile
{
    public CustomerMappingProfile()
    {
        this.CreateMap<CustomerRecord, CustomerData>();
    }
}
