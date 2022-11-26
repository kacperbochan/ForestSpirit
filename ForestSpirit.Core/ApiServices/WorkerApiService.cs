using AutoMapper;

using ForestSpirit.Framework.Products.Records;
using ForestSpirit.Framework.Workers;
using ForestSpirit.ServiceModel.Workers;

using ServiceStack;
using ServiceStack.FluentValidation;

namespace ForestSpirit.Core.ApiServices;

/// <summary>
/// Serwis api produktów.
/// </summary>
public class WorkerApiService : Service
{
    /// <summary>
    /// Serwis produktów.
    /// </summary>
    private readonly IWorkerService workersService;

    /// <summary>
    /// Silnik mapujący.
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkerApiService"/> class.
    /// </summary>
    /// <param name="workersService">Serwis produktów.</param>
    /// <param name="mapper">Silnik mapujący.</param>
    public WorkerApiService(IWorkerService workersService, IMapper mapper)
    {
        this.workersService = workersService;
        this.mapper = mapper;
    }

    /// <summary>
    /// Pobranie wszytskich produktów.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    public object Get(WorkerListRequest request)
    {
        var products = this.workersService.GetAll();
        var data = this.mapper.Map<List<WorkerRecord>, WorkerData[]>(products);
        return data;
    }

    /// <summary>
    /// Pobranie pojedyńczego produktu.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    public object Get(WorkerGetRequest request)
    {
        var product = this.workersService.Get(request.Id);

        if (product == null)
        {
            throw new NullReferenceException($"Couldn't find item with id {request.Id}");
        }

        var data = this.mapper.Map<WorkerRecord, WorkerData>(product);
        return data;
    }

    /// <summary>
    /// Dodanie noweg produktu do systemu.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    public object Any(WorkerCreateRequest request)
    {
        var validation = this.Request.TryResolve<IValidator<WorkerCreateRequest>>().Validate(request);

        if (!validation.IsValid)
        {
            throw new ValidationException($"Invalid object");
        }

        var builder = this.workersService.Create()
            .Name(request.Name)
            .Wage(request.Wage)
            .Type(request.Type)
            .Status(request.Status);

        var record = this.workersService.Save(builder);

        var data = this.mapper.Map<WorkerRecord, WorkerData>(record);
        return data;
    }
}