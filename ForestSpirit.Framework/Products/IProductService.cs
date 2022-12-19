using ForestSpirit.Framework.Products.Records;
using ForestSpirit.Framework.Data;
using ForestSpirit.Framework.Products.Records.Builders;

namespace ForestSpirit.Framework.Products;
public interface IProductService : IBuildableService<IProductRecordBuilder, ProductRecord>
{
    List<ProductRecord> GetAll();
    ProductRecord Get(int id);
}
