using ForestSpirit.Framework.Data;

namespace ForestSpirit.Framework.Products.Records;

/// <summary>
/// Rekord zgłoszenia.
/// </summary>
public class RequestRecord : AbstractRecord
{
    /// <summary>
    /// Tytół.
    /// </summary>
    public virtual string Title { get; set; }

    /// <summary>
    /// Zawartość.
    /// </summary>
    public virtual string Content { get; set; }

    /// <summary>
    /// Identyfikator wysyłającego.
    /// </summary>
    public virtual int SenderId { get; set; }

    /// <summary>
    /// Identyfikator odbiorcy.
    /// </summary>
    public virtual int ReceiverId { get; set; }

    /// <summary>
    /// Nadawca.
    /// </summary>
    public virtual WorkerRecord Sender { get; set; }

    /// <summary>
    /// Odbiorca.
    /// </summary>
    public virtual WorkerRecord Receiver { get; set; }
}
