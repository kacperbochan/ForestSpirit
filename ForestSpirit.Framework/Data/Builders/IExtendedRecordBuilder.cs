using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestSpirit.Framework.Data.Builders;
public interface IExtendedRecordBuilder<out TBuilder, out TRecord>
    where TBuilder : IRecordBuilder
    where TRecord : class
{
    /// <summary>
    /// Pobranie instacji rekordu.
    /// </summary>
    /// <returns>Instancja rekordu.</returns>
    TRecord Peek();

    /// <summary>
    /// Utworzenie obiektu rekordu.
    /// </summary>
    /// <returns>Rekord danych.</returns>
    TRecord Save();
}
