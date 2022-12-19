using ServiceStack.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestSpirit.Framework.Connection;
/// <summary>
/// Menadżer połączeń z repozytorium.
/// </summary>
public class DbConnectionManager : IDbConnectionManager
{
    /// <summary>
    /// Fabryki połączeń do baz danych.
    /// </summary>
    private readonly Dictionary<string, IDbConnectionFactory> factories =
        new Dictionary<string, IDbConnectionFactory>(StringComparer.CurrentCultureIgnoreCase);

    /// <inheritdoc />
    public IDbConnection OpenDbConnection(string name)
    {
        var factory = this.GetFactory(name);
        return factory.OpenDbConnection();
    }

    /// <summary>
    /// Zarejestrowanie fabryki połączeń do bazy danych.
    /// </summary>
    /// <param name="key">Nazwa połączenia.</param>
    /// <param name="factory">Fabryka połączenia.</param>
    public void Register(string key, IDbConnectionFactory factory)
    {
        if (key == null)
        {
            throw new ArgumentNullException(nameof(key));
        }

        this.factories[key] = factory ?? throw new ArgumentNullException(nameof(factory));
    }

    /// <summary>
    /// Pobranie fabryki połączeń do bazy danych.
    /// </summary>
    /// <param name="key">Nazwa połączenia.</param>
    public IDbConnectionFactory GetFactory(string key)
    {
        if (key == null)
        {
            throw new ArgumentNullException(nameof(key));
        }

        return this.factories[key];
    }
}