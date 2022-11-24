using ForestSpirit.Framework.Products.Records;
using ServiceStack.OrmLite;
using System.Data;

namespace ForestSpirit.Framework.Products;
public static class ProductQueryExtensions
{
    /// <summary>
    /// Tabela instalacji inwentarza.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <returns>Tabela danych.</returns>
    public static SqlExpression<ProductRecord> Product(this IDbConnection db) => db.From<ProductRecord>();

    /// <summary>
    /// Pobranie listy inwentarzy.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <param name="query">Kryteria filtrowania.</param>
    /// <returns>Lista inwentarzy.</returns>
    public static List<ProductRecord> Get(this IDbConnection db, SqlExpression<ProductRecord> query)
    {
        return db.Select(query);
    }
}
