using AutoMapper;
using ForestSpirit.Core.Controllers;
using ForestSpirit.Framework.Customers;
using ForestSpirit.Framework.Customers.Records;
using ForestSpirit.ServiceModel.Customers;
using Microsoft.AspNetCore.Mvc;

namespace ForestSpirit.Core.ApiServices;

/// <summary>
/// Serwis api produktów.
/// </summary>
[Route("/api/customers")]
[ApiController]
public class CustomersController : AbstractController
{
    /// <summary>
    /// Serwis produktów.
    /// </summary>
    private readonly ICustomerService customerService;

    /// <summary>
    /// Initializes a new instance of the <see cref="CustomersController"/> class.
    /// </summary>
    /// <param name="customerService">Serwis produktów.</param>
    /// <param name="mapper">Silnik mapujący.</param>
    public CustomersController(ICustomerService customerService, IMapper mapper)
        : base(mapper)
    {
        this.customerService = customerService;
    }

    /// <summary>
    /// Pobranie wszytskich produktów.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    [HttpGet]
    [Route("/api/customers/list")]
    public object Get()
    {
        var products = this.customerService.GetAll();
        var data = this.mapper.Map<List<CustomerRecord>, CustomerData[]>(products);
        return data;
    }

    /// <summary>
    /// Pobranie pojedyńczego produktu.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    [HttpGet]
    [Route("/api/customers")]
    public object Get([FromQuery] int key)
    {
        var product = this.customerService.Get(key);

        if (product == null)
        {
            throw new NullReferenceException($"Couldn't find item with id {key}");
        }

        var data = this.mapper.Map<CustomerRecord, CustomerData>(product);
        return data;
    }

    /// <summary>
    /// Dodanie noweg produktu do systemu.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    [HttpPost]
    [Route("/api/customers/create")]
    public object Any([FromBody] CustomerCreateRequest request)
    {
        /*var validation = this.Request.TryResolve<IValidator<CustomerCreateRequest>>().Validate(request);

        if (!validation.IsValid)
        {
            throw new ValidationException($"Invalid object");
        }*/

        var builder = this.customerService.Create()
            .Name(request.Name)
            .PublicName(request.PublicName);

        var record = this.customerService.Save(builder);

        var data = this.mapper.Map<CustomerRecord, CustomerData>(record);
        return data;
    }
}