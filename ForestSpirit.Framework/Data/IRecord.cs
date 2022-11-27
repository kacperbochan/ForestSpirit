namespace ForestSpirit.Framework.Data;

/// <summary>
/// Interfejs rekordu.
/// </summary>
public interface IRecord : ICloneable
{
    /// <summary>
    /// Identyfikator rekordu.
    /// </summary>
    int Id { get; set; }

    /// <summary>
    /// Data utworzenia.
    /// </summary>
    DateTime CreatedDate { get; set; }

    /// <summary>
    /// Data ostatniej modyfikacji.
    /// </summary>
    DateTime ChangedDate { get; set; }

    /// <summary>
    /// Imię, nazwisko użytkownika, który utworzył rekord.
    /// </summary>
    string CreatedBy { get; set; }

    /// <summary>
    /// Imię, nazwisko użytkownika, który dokonał modyfikacji.
    /// </summary>
    string ChangedBy { get; set; }
}
