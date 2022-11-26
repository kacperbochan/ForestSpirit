using ForestSpirit.Framework.Data.Builders;
using ForestSpirit.Framework.Outposts.Records;
using ForestSpirit.Framework.Workers.Records.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestSpirit.Framework.Resources.Records.Builders;
public interface IResourceRecordBuilder : IAbstractRecordBuilder<IResourceRecordBuilder>,
                                         IExtendedRecordBuilder<IResourceRecordBuilder, ResourceRecord>
{
    IResourceRecordBuilder Name(string value);
    IResourceRecordBuilder Quantity(int value);
    IResourceRecordBuilder ExpirationDate(DateTime value);
    IResourceRecordBuilder BuyDate(DateTime value);
    IResourceRecordBuilder Outpost(OutpostRecord value);
}
