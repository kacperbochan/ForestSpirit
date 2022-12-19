using ForestSpirit.Framework.Data.Builders;
using ForestSpirit.Framework.Products.Records;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestSpirit.Framework.Requests.Records.Builders;
public interface IRequestRecordBuilder : IAbstractRecordBuilder<IRequestRecordBuilder>,
                                         IExtendedRecordBuilder<IRequestRecordBuilder, RequestRecord>
{
    IRequestRecordBuilder Title(string value);
    IRequestRecordBuilder Content(string value);
    IRequestRecordBuilder Sender(WorkerRecord value);
    IRequestRecordBuilder Receiver(WorkerRecord value);
}
