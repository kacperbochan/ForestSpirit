using ForestSpirit.Framework.Data.Builders;
using System.Data;

namespace ForestSpirit.Framework.Products.Records.Builders;
public class ProductRecordBuilder : AbstractRecordBuilder<IProductRecordBuilder, ProductRecord>, IProductRecordBuilder
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductRecordBuilder"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    public ProductRecordBuilder(IDbConnection db)
        : base(db)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ProductRecordBuilder"/> class.
    /// </summary>
    /// <param name="db">Połączenie z repozytorium.</param>
    /// <param name="record">Rekord danych.</param>
    public ProductRecordBuilder(IDbConnection db, ProductRecord record)
        : base(db, record)
    {
    }

    public override IProductRecordBuilder GetNext() => this;
}
