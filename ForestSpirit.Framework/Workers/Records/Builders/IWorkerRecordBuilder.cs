using ForestSpirit.Framework.Data.Builders;
using ForestSpirit.Framework.Products.Records;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestSpirit.Framework.Workers.Records.Builders;
public interface IWorkerRecordBuilder : IAbstractRecordBuilder<IWorkerRecordBuilder>,
                                         IExtendedRecordBuilder<IWorkerRecordBuilder, WorkerRecord>
{
    IWorkerRecordBuilder Name(string value);
    IWorkerRecordBuilder Wage(float value);
    IWorkerRecordBuilder Type(short value);
    IWorkerRecordBuilder Status(short value);
}
