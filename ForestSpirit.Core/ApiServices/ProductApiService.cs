using AutoMapper;

using ForestSpirit.Framework.Products;
using ForestSpirit.Framework.Products.Records;
using ForestSpirit.ServiceModel.Products;

using ServiceStack;
using ServiceStack.FluentValidation;

namespace ForestSpirit.Core.ApiServices;

/// <summary>
/// Serwis api produktów.
/// </summary>
public class ProductApiService : Service
{
    /// <summary>
    /// Serwis produktów.
    /// </summary>
    private readonly IProductService productService;

    /// <summary>
    /// Silnik mapujący.
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// Initializes a new instance of the <see cref="ProductApiService"/> class.
    /// </summary>
    /// <param name="productService">Serwis produktów.</param>
    /// <param name="mapper">Silnik mapujący.</param>
    public ProductApiService(IProductService productService, IMapper mapper)
    {
        this.productService = productService;
        this.mapper = mapper;
    }

    /// <summary>
    /// Pobranie wszytskich produktów.
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
    /// Pobranie pojedyńczego produktu.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    public object Get(ProductGetRequest request)
    {
        var product = this.productService.Get(request.Id);

        if (product == null)
        {
            throw new NullReferenceException($"Couldn't find item with id {request.Id}");
        }

        var data = this.mapper.Map<ProductRecord, ProductData>(product);
        return data;
    }

    /// <summary>
    /// Dodanie noweg produktu do systemu.
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

        var builder = this.productService.Create()
            .Name(request.Name)
            .Procentage(request.Procentage)
            .Price(request.Price);

        var record = this.productService.Save(builder);

        var data = this.mapper.Map<ProductRecord, ProductData>(record);
        return data;
    }
}