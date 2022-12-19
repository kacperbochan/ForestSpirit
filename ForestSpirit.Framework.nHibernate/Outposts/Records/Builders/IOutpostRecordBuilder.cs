using ForestSpirit.Framework.Data.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestSpirit.Framework.Outposts.Records.Builders;
public interface IOutpostRecordBuilder : IAbstractRecordBuilder<IOutpostRecordBuilder>,
                                         IExtendedRecordBuilder<IOutpostRecordBuilder, OutpostRecord>
{
    IOutpostRecordBuilder Name(string value);
    IOutpostRecordBuilder Latitude(double value);
    IOutpostRecordBuilder Longitude(double value);
}
