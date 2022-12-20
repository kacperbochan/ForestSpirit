using ForestSpirit.Framework.Data.Builders;
using ForestSpirit.Framework.Equipments.Records.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestSpirit.Framework.Customers.Records.Builders;
public interface ICustomerRecordBuilder : IAbstractRecordBuilder<ICustomerRecordBuilder>,
                                         IExtendedRecordBuilder<ICustomerRecordBuilder, CustomerRecord>
{
    ICustomerRecordBuilder Name(string value);
    ICustomerRecordBuilder PublicName(string value);
}
