using AutoMapper;
using ForestSpirit.Core.Controllers;
using ForestSpirit.Framework.Customers;
using ForestSpirit.Framework.Opinions;
using ForestSpirit.Framework.Opinions.Records;
using ForestSpirit.Framework.Products;
using ForestSpirit.ServiceModel.Opinions;
using Microsoft.AspNetCore.Mvc;

namespace ForestSpirit.Core.ApiServices;

/// <summary>
/// Serwis api produktów.
/// </summary>
[Route("/api/opinions")]
[ApiController]
public class OpinionsController : AbstractController
{
    /// <summary>
    /// Serwis produktów.
    /// </summary>
    private readonly IOpinionService opinionsService;

    /// <summary>
    /// Serwis produktów.
    /// </summary>
    private readonly IProductService productService;

    /// <summary>
    /// Serwis produktów.
    /// </summary>
    private readonly ICustomerService customerService;

    /// <summary>
    /// Initializes a new instance of the <see cref="OpinionsController"/> class.
    /// </summary>
    /// <param name="opinionsService">Serwis produktów.</param>
    /// <param name="mapper">Silnik mapujący.</param>
    public OpinionsController(IOpinionService opinionsService, ICustomerService customerService, IProductService productService, IMapper mapper)
        : base(mapper)
    {
        this.opinionsService = opinionsService;
        this.productService = productService;
        this.customerService = customerService;
    }

    /// <summary>
    /// Pobranie wszytskich produktów.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    [HttpGet]
    [Route("/api/opinions/list")]
    public object Get(OpinionListRequest request)
    {
        var products = this.opinionsService.GetAll();
        var data = this.mapper.Map<List<OpinionRecord>, OpinionData[]>(products);
        return data;
    }

    /// <summary>
    /// Pobranie pojedyńczego produktu.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    [HttpGet]
    [Route("/api/opinions")]
    public object Get([FromQuery] int key)
    {
        var product = this.opinionsService.Get(key);

        if (product == null)
        {
            throw new NullReferenceException($"Couldn't find item with id {key}");
        }

        var data = this.mapper.Map<OpinionRecord, OpinionData>(product);
        return data;
    }

    /// <summary>
    /// Dodanie noweg produktu do systemu.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    [HttpPost]
    [Route("/api/opinions/create")]
    public object Any(OpinionCreateRequest request)
    {
      /*  var validation = this.Request.TryResolve<IValidator<OpinionCreateRequest>>().Validate(request);

        if (!validation.IsValid)
        {
            throw new ValidationException($"Invalid object");
        }*/

        var product = this.productService.Get(request.ProductId);

        if (product == null)
        {
            throw new NullReferenceException();
        }

        var customer = this.customerService.Get(request.CustomerId);

        if (customer == null)
        {
            throw new NullReferenceException();
        }

        var builder = this.opinionsService.Create()
            .Text(request.Text)
            .Rating(request.Rating)
            .Product(product)
            .Customer(customer);

        var record = this.opinionsService.Save(builder);

        var data = this.mapper.Map<OpinionRecord, OpinionData>(record);
        return data;
    }
}