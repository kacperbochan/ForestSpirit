using ForestSpirit.Framework.Data.Records;
using ForestSpirit.Framework.Products.Records;
using ForestSpirit.Framework.Products.Records.Builders;
using NHibernate;
using System.Data;

namespace ForestSpirit.Framework.Products.Providers;
public class ProductService : AbstractService<ProductRecord>, IProductService
{
    public ProductService(ISessionFactory db)
        : base(db)
    {
    }

    public IProductRecordBuilder Create()
    {
        var builder = new ProductRecordBuilder(this.Db);
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
            record = builder.Id(this.GetNewId()).Save();
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
        return new ProductRecordBuilder(this.Db, item);
    }

    public ProductRecord Get(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return null;
        }

        // pobranie danych
        using (var session = this.Db.OpenSession())
        {
            return session.Query<ProductRecord>().Where(x => x.Name == name).FirstOrDefault();
        }
    }

    public ProductRecord Get(int id)
    {
        if (id<0)
        {
            return null;
        }

        // pobranie danych
        using (var session = this.Db.OpenSession())
        {
            return session.Query<ProductRecord>().Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
