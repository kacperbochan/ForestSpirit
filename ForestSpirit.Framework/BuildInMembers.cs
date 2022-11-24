using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestSpirit.Framework;
/// <summary>
/// Klasa zawierająca użytkowników i grupy wbudowane.
/// </summary>
public static class BuildInMembers
{
    /// <summary>
    /// Guid użytkownika reprezentującego system.
    /// </summary>
    public const string System = "SYSTEM";

    /// <summary>
    /// Grupa administratorów.
    /// </summary>
    public const string Administrators = "Administrators";

    /// <summary>
    /// Grupa użytkowników.
    /// </summary>
    public const string Users = "Users";

    /// <summary>
    /// Grupa synchronizacji.
    /// </summary>
    public const string Synchronizer = "SYNC";
}
