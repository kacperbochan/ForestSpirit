using ForestSpirit.Framework.Customers.Records;
using ForestSpirit.Framework.Equipments.Records;
using ForestSpirit.Framework.Opinions.Records;
using ForestSpirit.Framework.Orders.Records;
using ForestSpirit.Framework.Outposts.Records;
using ForestSpirit.Framework.Products.Records;
using ForestSpirit.Framework.Resources.Records;

using ServiceStack.OrmLite;
using System.Data;

namespace ForestSpirit.Framework;
public static class QueryExtensions
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

    /// <summary>
    /// Tabela instalacji inwentarza.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <returns>Tabela danych.</returns>
    public static SqlExpression<CustomerRecord> Customer(this IDbConnection db) => db.From<CustomerRecord>();

    /// <summary>
    /// Pobranie listy inwentarzy.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <param name="query">Kryteria filtrowania.</param>
    /// <returns>Lista inwentarzy.</returns>
    public static List<CustomerRecord> Get(this IDbConnection db, SqlExpression<CustomerRecord> query)
    {
        return db.Select(query);
    }

    /// <summary>
    /// Tabela instalacji inwentarza.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <returns>Tabela danych.</returns>
    public static SqlExpression<WorkerRecord> Worker(this IDbConnection db) => db.From<WorkerRecord>();

    /// <summary>
    /// Pobranie listy inwentarzy.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <param name="query">Kryteria filtrowania.</param>
    /// <returns>Lista inwentarzy.</returns>
    public static List<WorkerRecord> Get(this IDbConnection db, SqlExpression<WorkerRecord> query)
    {
        return db.Select(query);
    }

    /// <summary>
    /// Tabela instalacji inwentarza.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <returns>Tabela danych.</returns>
    public static SqlExpression<OutpostRecord> Outpost(this IDbConnection db) => db.From<OutpostRecord>();

    /// <summary>
    /// Pobranie listy inwentarzy.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <param name="query">Kryteria filtrowania.</param>
    /// <returns>Lista inwentarzy.</returns>
    public static List<OutpostRecord> Get(this IDbConnection db, SqlExpression<OutpostRecord> query)
    {
        return db.Select(query);
    }

    /// <summary>
    /// Tabela instalacji inwentarza.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <returns>Tabela danych.</returns>
    public static SqlExpression<OpinionRecord> Opinion(this IDbConnection db) => db.From<OpinionRecord>();

    /// <summary>
    /// Pobranie listy inwentarzy.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <param name="query">Kryteria filtrowania.</param>
    /// <returns>Lista inwentarzy.</returns>
    public static List<OpinionRecord> Get(this IDbConnection db, SqlExpression<OpinionRecord> query)
    {
        return db.Select(query);
    }

    /// <summary>
    /// Tabela instalacji inwentarza.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <returns>Tabela danych.</returns>
    public static SqlExpression<OrderRecord> Order(this IDbConnection db) => db.From<OrderRecord>();

    /// <summary>
    /// Pobranie listy inwentarzy.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <param name="query">Kryteria filtrowania.</param>
    /// <returns>Lista inwentarzy.</returns>
    public static List<OrderRecord> Get(this IDbConnection db, SqlExpression<OrderRecord> query)
    {
        return db.Select(query);
    }

    /// <summary>
    /// Tabela instalacji inwentarza.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <returns>Tabela danych.</returns>
    public static SqlExpression<EquipmentRecord> Equipment(this IDbConnection db) => db.From<EquipmentRecord>();

    /// <summary>
    /// Pobranie listy inwentarzy.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <param name="query">Kryteria filtrowania.</param>
    /// <returns>Lista inwentarzy.</returns>
    public static List<EquipmentRecord> Get(this IDbConnection db, SqlExpression<EquipmentRecord> query)
    {
        return db.Select(query);
    }

    /// <summary>
    /// Tabela instalacji inwentarza.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <returns>Tabela danych.</returns>
    public static SqlExpression<ResourceRecord> Resources(this IDbConnection db) => db.From<ResourceRecord>();

    /// <summary>
    /// Pobranie listy inwentarzy.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <param name="query">Kryteria filtrowania.</param>
    /// <returns>Lista inwentarzy.</returns>
    public static List<ResourceRecord> Get(this IDbConnection db, SqlExpression<ResourceRecord> query)
    {
        return db.Select(query);
    }

    /// <summary>
    /// Tabela instalacji inwentarza.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <returns>Tabela danych.</returns>
    public static SqlExpression<RequestRecord> Request(this IDbConnection db) => db.From<RequestRecord>();

    /// <summary>
    /// Pobranie listy inwentarzy.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <param name="query">Kryteria filtrowania.</param>
    /// <returns>Lista inwentarzy.</returns>
    public static List<RequestRecord> Get(this IDbConnection db, SqlExpression<RequestRecord> query)
    {
        return db.Select(query);
    }
}
