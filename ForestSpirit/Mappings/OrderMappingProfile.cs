using AutoMapper;
using ForestSpirit.Framework.Orders.Records;
using ForestSpirit.ServiceModel.Orders;

namespace ForestSpirit.Mappings;

public class OrderMappingProfile : Profile
{
    public OrderMappingProfile()
    {
        this.CreateMap<OrderRecord, OrderData>();
    }
}
