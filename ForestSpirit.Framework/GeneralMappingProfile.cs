using AutoMapper;
using ForestSpirit.Framework.Customers.Records;
using ForestSpirit.Framework.Equipments.Records;
using ForestSpirit.Framework.Opinions.Records;
using ForestSpirit.Framework.Orders.Records;
using ForestSpirit.Framework.Outposts.Records;
using ForestSpirit.Framework.Products.Records;
using ForestSpirit.Framework.Resources.Records;
using ForestSpirit.ServiceModel.Customers;
using ForestSpirit.ServiceModel.Equipments;
using ForestSpirit.ServiceModel.Opinions;
using ForestSpirit.ServiceModel.Orders;
using ForestSpirit.ServiceModel.Outposts;
using ForestSpirit.ServiceModel.Products;
using ForestSpirit.ServiceModel.Resources;
using ForestSpirit.ServiceModel.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestSpirit.Framework;
public class GeneralMappingProfile : Profile
{
    public GeneralMappingProfile()
    {
        this.CreateMap<CustomerRecord, CustomerData>();
        this.CreateMap<EquipmentRecord, EquipmentData>();
        this.CreateMap<OpinionRecord, OpinionData>();
        this.CreateMap<OrderRecord, OrderData>();
        this.CreateMap<OutpostRecord, OutpostData>();
        this.CreateMap<ProductRecord, ProductData>();
        this.CreateMap<ResourceRecord, ResourceData>();
        this.CreateMap<WorkerRecord, WorkerData>();
    }
}
