using ServiceStack.DataAnnotations;

namespace ForestSpirit.Framework.Data;

/// <summary>
/// Akstrakcyjna klasa rekordu przechowująca podstawowe dane.
/// </summary>
public abstract class AbstractRecord : IRecord
{
    /// <summary>
    /// Identyfikator rekordu.
    /// </summary>
    public virtual int Id { get; set; }

    /// <summary>
    /// Data stworzenia.
    /// </summary>
    public virtual DateTime CreatedDate { get; set; }

    /// <summary>
    /// Data modyfikacji.
    /// </summary>
    public virtual DateTime ChangedDate { get; set; }

    /// <summary>
    /// Kto stworzył rekord.
    /// </summary>
    public virtual string CreatedBy { get; set; }

    /// <summary>
    /// Kto zmodyfikował rekord.
    /// </summary>
    public virtual string ChangedBy { get; set; }

    /// <inheritdoc />
    public virtual object Clone() => this.Clone();
}