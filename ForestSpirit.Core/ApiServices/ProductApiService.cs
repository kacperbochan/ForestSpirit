using AutoMapper;
using ForestSpirit.Framework.Products;
using ForestSpirit.Framework.Products.Records;
using ForestSpirit.ServiceModel.Products;
using Microsoft.AspNetCore.Mvc;

namespace ForestSpirit.Core.ApiServices;

/// <summary>
/// Serwis api produktów.
/// </summary>
[Route("/api/products")]
[ApiController]
public class ProductApiService : Controller
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
    [HttpGet]
    [Route("/api/products/list")]
    public object Get()
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
    [HttpGet]
    [Route("/api/products/get")]
    public object Get([FromQuery] int key)
    {
        var product = this.productService.Get(key);

        if (product == null)
        {
            throw new NullReferenceException($"Couldn't find item with id {key}");
        }

        var data = this.mapper.Map<ProductRecord, ProductData>(product);
        return data;
    }

    /// <summary>
    /// Dodanie noweg produktu do systemu.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    [HttpPost]
    [Route("/api/products/create")]
    public object Any(ProductCreateRequest request)
    {
        //var validation = this.Request.TryResolve<IValidator<ProductCreateRequest>>().Validate(request);

        /* if (!validation.IsValid)
         {
             throw new ValidationException($"Invalid object");
         }*/

        var builder = this.productService.Create()
            .Name(request.Name)
            .Procentage(request.Procentage)
            .Price(request.Price);

        var record = this.productService.Save(builder);

        var data = this.mapper.Map<ProductRecord, ProductData>(record);
        return data;
    }

    /// <summary>
    /// Dodanie noweg produktu do systemu.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    [HttpPost]
    [Route("/api/products/update")]
    public object Any([FromQuery] int key, [FromBody] ProductUpdateRequest request)
    {
        //var validation = this.Request.TryResolve<IValidator<ProductCreateRequest>>().Validate(request);

        /* if (!validation.IsValid)
         {
             throw new ValidationException($"Invalid object");
         }*/

        var product = this.productService.Get(key);

        var builder = this.productService.Update(product)
            .Name(request.Name)
            .Procentage(request.Procentage)
            .Price(request.Price);

        var record = this.productService.Save(builder);

        var data = this.mapper.Map<ProductRecord, ProductData>(record);
        return data;
    }
}