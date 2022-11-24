using ForestSpirit.Framework.Data.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestSpirit.Framework.Products.Records.Builders;
public interface IProductRecordBuilder : IAbstractRecordBuilder<IProductRecordBuilder>,
                                         IExtendedRecordBuilder<IProductRecordBuilder, ProductRecord>
{
}
