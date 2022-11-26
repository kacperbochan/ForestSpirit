using ForestSpirit.Framework.Data.Builders;
using ForestSpirit.Framework.Outposts.Records.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestSpirit.Framework.Orders.Records.Builders;
public interface IOrderRecordBuilder : IAbstractRecordBuilder<IOrderRecordBuilder>,
                                         IExtendedRecordBuilder<IOrderRecordBuilder, OrderRecord>
{
    IOrderRecordBuilder OrderDate(DateTime value);
    IOrderRecordBuilder CustomerId(int value);
    IOrderRecordBuilder Price(float value);
    IOrderRecordBuilder Status(short value);
    IOrderRecordBuilder PredictedDeliveryDate(DateTime value);
}
