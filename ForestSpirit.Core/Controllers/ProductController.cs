using AutoMapper;

using ForestSpirit.Framework.Products;
using ForestSpirit.Framework.Products.Records;
using ForestSpirit.ServiceModel.Products;

using ServiceStack;
using ServiceStack.FluentValidation;

namespace ForestSpirit.Core.Controllers;

public class ProductController : Service
{
    IProductService productService;
    IMapper mapper;

    public ProductController(IProductService productService, IMapper mapper)
    {
        this.productService = productService;
        this.mapper = mapper;
    }

    /// <summary>
    /// Dodanie noweg zlecenia do systemu.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    public object Get(ProductListRequest request)
    {
        var products = this.productService.GetAll();
        var data = this.mapper.Map<List<ProductRecord>, ProductData[]>(products);
        return data;
    }

    /// <summary>
    /// Dodanie noweg zlecenia do systemu.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    public object Any(ProductCreateRequest request)
    {
        var validation = this.Request.TryResolve<IValidator<ProductCreateRequest>>().Validate(request);

        if (!validation.IsValid)
        {
            throw new ValidationException($"Invalid object");
        }

        var builder = this.productService.Create().Name(request.Name).Procentage(request.Procentage).Price(request.Price);

        var record = this.productService.Save(builder);

        var data = this.mapper.Map<ProductRecord, ProductData>(record);
        return data;
    }
}
