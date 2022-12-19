using ForestSpirit.Framework.Data.Builders;

namespace ForestSpirit.Framework.Data;

/// <summary>
/// Interfejs umożliwiajacy stworzenie, aktualizację i zapis rekordów.
/// </summary>
/// <typeparam name="TBuilder">Typ kreatora.</typeparam>
/// <typeparam name="TRecord">Typ rekordu.</typeparam>
public interface IBuildableService<TBuilder, TRecord>
    where TBuilder : IRecordBuilder
{
    /// <summary>
    /// Kreator nowego rekordu.
    /// </summary>
    /// <returns>Kreator rekordu.</returns>
    TBuilder Create();

    /// <summary>
    /// Kreator aktualizacji rekordu.
    /// </summary>
    /// <param name="item">Rekord danych.</param>
    /// <returns>Kreator rekordu.</returns>
    TBuilder Update(TRecord item);

    /// <summary>
    /// Zapis kreatora rekordu.
    /// </summary>
    /// <param name="builder">Kreator rekordu.</param>
    /// <returns>Rekord danych.</returns>
    TRecord Save(TBuilder builder);
}
