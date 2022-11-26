using ForestSpirit.Framework.Data.Builders;
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
    IOpinionRecordBuilder CustomerId(int value);
    IOpinionRecordBuilder ProductId(int value);
}
