using AutoMapper;
using ForestSpirit.Framework.Products.Records;
using ForestSpirit.ServiceModel.Products;

namespace ForestSpirit.Mappings;

public class ProductMappingProfile : Profile
{
    public ProductMappingProfile()
    {
        this.CreateMap<ProductRecord, ProductData>();
    }
}
