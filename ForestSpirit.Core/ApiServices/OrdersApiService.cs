using AutoMapper;
using ForestSpirit.Framework.Customers;
using ForestSpirit.Framework.Orders;
using ForestSpirit.Framework.Orders.Records;
using ForestSpirit.ServiceModel.Orders;

using ServiceStack;
using ServiceStack.FluentValidation;

namespace ForestSpirit.Core.Controllers;

/// <summary>
/// Serwis api produktów.
/// </summary>
public class OrdersApiService : Service
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
    /// Silnik mapujący.
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// Initializes a new instance of the <see cref="OrdersApiService"/> class.
    /// </summary>
    /// <param name="ordersService">Serwis produktów.</param>
    /// <param name="mapper">Silnik mapujący.</param>
    public OrdersApiService(IOrderService ordersService, ICustomerService customerService, IMapper mapper)
    {
        this.ordersService = ordersService;
        this.customerService = customerService;
        this.mapper = mapper;
    }

    /// <summary>
    /// Pobranie wszytskich produktów.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
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
    public object Get(OrderGetRequest request)
    {
        var product = this.ordersService.Get(request.Id);

        if (product == null)
        {
            throw new NullReferenceException($"Couldn't find item with id {request.Id}");
        }

        var data = this.mapper.Map<OrderRecord, OrderData>(product);
        return data;
    }

    /// <summary>
    /// Dodanie noweg produktu do systemu.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    public object Any(OrderCreateRequest request)
    {
        var validation = this.Request.TryResolve<IValidator<OrderCreateRequest>>().Validate(request);

        if (!validation.IsValid)
        {
            throw new ValidationException($"Invalid object");
        }

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