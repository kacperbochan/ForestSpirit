using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestSpirit.Framework.Data.Builders;
public interface IAbstractRecordBuilder<out TBuilder> : IRecordBuilder
    where TBuilder : IRecordBuilder
{
    /// <summary>
    /// Ustawienie identyfikatora utworzenia rekordu.
    /// </summary>
    /// <param name="value">Identyfikator utworzenia rekordu.</param>
    /// <returns>Kreator rekordu.</returns>
    TBuilder Id(int value);

    /// <summary>
    /// Ustawienie daty i czasu utworzenia rekordu.
    /// </summary>
    /// <param name="value">Data i czas utworzenia rekordu.</param>
    /// <returns>Kreator rekordu.</returns>
    TBuilder CreatedAt(DateTime value);

    /// <summary>
    /// Ustawienie daty zmiany rekordu.
    /// </summary>
    /// <param name="value">Wartość atrybutu.</param>
    /// <returns>Kreator rekordu.</returns>
    TBuilder ChangedAt(DateTime value);

    /// <summary>
    /// Ustawienie autora tworzonego rekordu.
    /// </summary>
    /// <param name="value">Nazwa użytkownika.</param>
    /// <returns>Kreator rekordu.</returns>
    TBuilder CreatedBy(string value);

    /// <summary>
    /// Ustawienie autora zmiany rekordu.
    /// </summary>
    /// <param name="value">Wartość atrybutu.</param>
    /// <returns>Kreator rekordu.</returns>
    TBuilder ChangedBy(string value);
}
