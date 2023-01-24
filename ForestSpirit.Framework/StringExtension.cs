using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ForestSpirit.Framework;
public static class StringExtension
{
    public static string Join(this IEnumerable<string> items, char character)
    {
        return string.Join(character, items);
    }

    public static string Join(this IEnumerable<string> items, string str)
    {
        return string.Join(str, items);
    }

    public static IEnumerable<string> DeNormaize(this string item)
    {
        return item.Split(';');
    }

    public static string Normaize(this IEnumerable<string> items)
    {
        return items.Join(';');
    }
}
