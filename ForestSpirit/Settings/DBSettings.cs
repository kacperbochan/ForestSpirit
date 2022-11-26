namespace ForestSpirit.Settings;

/// <summary>
/// Ustawienia połączenia do repozytorium.
/// </summary>
public class DBSettings
{
    /// <summary>
    /// Dostawca bazy danych.
    /// </summary>
    public string Dialect { get; set; }

    /// <summary>
    /// Parametry połączenia.
    /// </summary>
    public string ConnectionString { get; set; }
}
