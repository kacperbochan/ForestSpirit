using ForestSpirit.ServiceModel.Products;
using ServiceStack.Script;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestSpirit.Framework.Products.Providers;
public class ProductCategories
{
    private static ProductCategory[] data;
    public static ProductCategories Instance = new();

    static ProductCategories()
    {
        data = new[]
        {
            Vodka,
            Bear,
            NoAlcohol,
            Wine,
        };
    }

    public static readonly ProductCategory Vodka = new ProductCategory
    {
        Name = "Product_Category_Vodka",
        Code = 0,
    };

    public static readonly ProductCategory Bear = new ProductCategory
    {
        Name = "Product_Category_Bear",
        Code = 1,
    };

    public static readonly ProductCategory NoAlcohol = new ProductCategory
    {
        Name = "Product_Category_No_Alcohol",
        Code = 2,
    };

    public static readonly ProductCategory Wine = new ProductCategory
    {
        Name = "Product_Category_Wine",
        Code = 3,
    };

    public IEnumerable<ProductCategory> GetData()
    {
        return data;
    }
}
