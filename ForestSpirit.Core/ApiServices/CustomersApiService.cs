using AutoMapper;
using ForestSpirit.Framework.Customers;
using ForestSpirit.Framework.Customers.Records;
using ForestSpirit.ServiceModel.Customers;

using ServiceStack;
using ServiceStack.FluentValidation;

namespace ForestSpirit.Core.ApiServices;

/// <summary>
/// Serwis api produktów.
/// </summary>
public class CustomersApiService : Service
{
    /// <summary>
    /// Serwis produktów.
    /// </summary>
    private readonly ICustomerService customerService;

    /// <summary>
    /// Silnik mapujący.
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// Initializes a new instance of the <see cref="CustomersApiService"/> class.
    /// </summary>
    /// <param name="customerService">Serwis produktów.</param>
    /// <param name="mapper">Silnik mapujący.</param>
    public CustomersApiService(ICustomerService customerService, IMapper mapper)
    {
        this.customerService = customerService;
        this.mapper = mapper;
    }

    /// <summary>
    /// Pobranie wszytskich produktów.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    public object Get(CustomerListRequest request)
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
    public object Get(CustomerGetRequest request)
    {
        var product = this.customerService.Get(request.Id);

        if (product == null)
        {
            throw new NullReferenceException($"Couldn't find item with id {request.Id}");
        }

        var data = this.mapper.Map<CustomerRecord, CustomerData>(product);
        return data;
    }

    /// <summary>
    /// Dodanie noweg produktu do systemu.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    public object Any(CustomerCreateRequest request)
    {
        var validation = this.Request.TryResolve<IValidator<CustomerCreateRequest>>().Validate(request);

        if (!validation.IsValid)
        {
            throw new ValidationException($"Invalid object");
        }

        var builder = this.customerService.Create()
            .Name(request.Name)
            .PublicName(request.PublicName);

        var record = this.customerService.Save(builder);

        var data = this.mapper.Map<CustomerRecord, CustomerData>(record);
        return data;
    }
}