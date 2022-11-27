using ForestSpirit.Framework.Data.Records;
using ForestSpirit.Framework.Products.Records;
using ForestSpirit.Framework.Products.Records.Builders;
using System.Data;

namespace ForestSpirit.Framework.Products.Providers;
public class ProductService : IProductService
{
    /// <summary>
    /// Połączenie z bazą danych.
    /// </summary>
    private readonly IDbConnection db;

    public ProductService(IDbConnection db)
    {
        this.db = db ?? throw new ArgumentNullException(nameof(db));
    }

    public IProductRecordBuilder Create()
    {
        var builder = new ProductRecordBuilder(this.db);
        DateTime timestamp = DateTime.UtcNow;
        return builder.CreatedAt(timestamp).CreatedBy("SYSTEM").ChangedAt(timestamp).ChangedBy("SYSTEM");
    }

    public ProductRecord Save(IProductRecordBuilder builder)
    {
        ProductRecord record;
        if (builder == null)
        {
            throw new ArgumentNullException(nameof(builder));
        }

        // Jezeli rekord jest nowy.
        if (builder.Peek().IsNew())
        {
            record = builder.Save();
        }
        else
        {
            // aktualizacja nastepuje tylko jesli dokonano jakichs zmian
            if (builder.HasChanged())
            {
                builder.ChangedBy("SYSTEM")
                   .ChangedAt(DateTime.Now);
            }

            record = builder.Save();
        }

        return record;
    }

    public IProductRecordBuilder Update(ProductRecord item)
    {
        return new ProductRecordBuilder(this.db, item);
    }

    public ProductRecord Get(int id)
    {
        if (id <= 0)
        {
            return null;
        }

        // pobranie danych
        var data = this.db.Product().Where(x => x.Id == id);
        var result = this.db.Get(data).FirstOrDefault();
        return result;
    }

    public ProductRecord Get(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return null;
        }

        // pobranie danych
        var data = this.db.Product().Where(x => x.Name == name);
        var result = this.db.Get(data).FirstOrDefault();
        return result;
    }

    public List<ProductRecord> GetAll()
    {
        // pobranie danych
        var data = this.db.Product();
        return this.db.Get(data);
    }
}
