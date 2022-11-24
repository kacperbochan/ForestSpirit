using System.Data;

namespace ForestSpirit.Framework.Data.Builders;

/// <summary>
/// Interfejs kreatora rekordu.
/// </summary>
public interface IRecordBuilder
{
    /// <summary>
    /// Połączenie z repozytorium.
    /// </summary>
    IDbConnection Db { get; }

    /// <summary>
    /// Sprawdzenie, czy rekord został zmieniony w stosunku do początkowych ustawień.
    /// </summary>
    /// <returns>True jeśli właściwości rekordu zmieniły się.</returns>
    bool HasChanged();
}
