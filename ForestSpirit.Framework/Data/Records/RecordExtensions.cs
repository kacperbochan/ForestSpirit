using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestSpirit.Framework.Data.Records;
public static class RecordExtensions
{
    /// <summary>
    /// Czy rekord jest nowy.
    /// </summary>
    /// <param name="record">Rekord.</param>
    /// <returns>True jeśli rekord jest nowy (INSERT), False w przypadku aktualizacji (UPDATE).</returns>
    public static bool IsNew(this IRecord record)
    {
        if (record == null)
        {
            throw new ArgumentNullException(nameof(record));
        }

        return record.ID <= 0;
    }
}