using ForestSpirit.Framework.Customers.Records;
using ForestSpirit.Framework.Data.Builders;
using ForestSpirit.Framework.Products.Records;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestSpirit.Framework.Opinions.Records.Builders;
public interface IOpinionRecordBuilder : IAbstractRecordBuilder<IOpinionRecordBuilder>,
                                         IExtendedRecordBuilder<IOpinionRecordBuilder, OpinionRecord>
{
    IOpinionRecordBuilder Text(string value);
    IOpinionRecordBuilder Rating(int value);
    IOpinionRecordBuilder Customer(CustomerRecord value);
    IOpinionRecordBuilder Product(ProductRecord value);
}
