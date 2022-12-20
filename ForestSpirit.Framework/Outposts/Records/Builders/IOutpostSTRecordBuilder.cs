using ForestSpirit.Framework.Data.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestSpirit.Framework.Outposts.Records.Builders;
public interface IOutpostSTRecordBuilder : IAbstractRecordBuilder<IOutpostSTRecordBuilder>,
                                         IExtendedRecordBuilder<IOutpostSTRecordBuilder, OutpostSTRecord>
{
    IOutpostSTRecordBuilder OrderCount(int value);
}
