using AutoMapper;
using ForestSpirit.Framework.Customers;
using ForestSpirit.Framework.Orders;
using ForestSpirit.Framework.Orders.Records;
using ForestSpirit.ServiceModel.Orders;

using Microsoft.AspNetCore.Mvc;
namespace ForestSpirit.Core.Controllers;

/// <summary>
/// Serwis api produktów.
/// </summary>
[Route("/api/orders")]
[ApiController]
public class OrdersController : AbstractController
{
    /// <summary>
    /// Serwis produktów.
    /// </summary>
    private readonly IOrderService ordersService;

    /// <summary>
    /// Serwis produktów.
    /// </summary>
    private readonly ICustomerService customerService;

    /// <summary>
    /// Initializes a new instance of the <see cref="OrdersController"/> class.
    /// </summary>
    /// <param name="ordersService">Serwis produktów.</param>
    /// <param name="mapper">Silnik mapujący.</param>
    public OrdersController(IOrderService ordersService, ICustomerService customerService, IMapper mapper)
        : base(mapper)
    {
        this.ordersService = ordersService;
        this.customerService = customerService;
    }

    /// <summary>
    /// Pobranie wszytskich produktów.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    [HttpGet]
    [Route("/api/orders/list")]
    public object Get(OrderListRequest request)
    {
        var products = this.ordersService.GetAll();
        var data = this.mapper.Map<List<OrderRecord>, OrderData[]>(products);
        return data;
    }

    /// <summary>
    /// Pobranie pojedyńczego produktu.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    [HttpGet]
    [Route("/api/orders")]
    public object Get([FromQuery] int key)
    {
        var product = this.ordersService.Get(key);

        if (product == null)
        {
            throw new NullReferenceException($"Couldn't find item with id {key}");
        }

        var data = this.mapper.Map<OrderRecord, OrderData>(product);
        return data;
    }

    /// <summary>
    /// Dodanie noweg produktu do systemu.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    [HttpPost]
    [Route("/api/orders/create")]
    public object Any(OrderCreateRequest request)
    {
        /*var validation = this.Request.TryResolve<IValidator<OrderCreateRequest>>().Validate(request);

        if (!validation.IsValid)
        {
            throw new ValidationException($"Invalid object");
        }*/

        var customer = this.customerService.Get(request.CustomerId);

        if (customer == null)
        {
            throw new NullReferenceException();
        }

        var builder = this.ordersService.Create()
            .OrderDate(request.OrderDate)
            .Customer(customer)
            .Price(request.Price)
            .Status(request.Status)
            .PredictedDeliveryDate(request.PredictedDeliveryDate);

        var record = this.ordersService.Save(builder);

        var data = this.mapper.Map<OrderRecord, OrderData>(record);
        return data;
    }
}