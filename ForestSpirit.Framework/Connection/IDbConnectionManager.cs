using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestSpirit.Framework.Connection;
/// <summary>
/// Interfejs menadżera połączeń z repozytorium.
/// </summary>
public interface IDbConnectionManager
{
    /// <summary>
    /// Otwarcie połączenia z repozytorium.
    /// </summary>
    /// <param name="name">Nazwa połączenia.</param>
    /// <returns>Połączenie z bazą danych.</returns>
    IDbConnection OpenDbConnection(string name);
}