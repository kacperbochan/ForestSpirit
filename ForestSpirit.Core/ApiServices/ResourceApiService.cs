using AutoMapper;
using ForestSpirit.Framework.Outposts;
using ForestSpirit.Framework.Resources;
using ForestSpirit.Framework.Resources.Records;
using ForestSpirit.ServiceModel.Resources;

using ServiceStack;
using ServiceStack.FluentValidation;

namespace ForestSpirit.Core.ApiServices;

/// <summary>
/// Serwis api produktów.
/// </summary>
public class ResourceApiService : Service
{
    /// <summary>
    /// Serwis produktów.
    /// </summary>
    private readonly IResourceService resourceService;

    /// <summary>
    /// Serwis produktów.
    /// </summary>
    private readonly IOutpostService outpostService;

    /// <summary>
    /// Silnik mapujący.
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// Initializes a new instance of the <see cref="ResourceApiService"/> class.
    /// </summary>
    /// <param name="resourceService">Serwis produktów.</param>
    /// <param name="mapper">Silnik mapujący.</param>
    public ResourceApiService(IResourceService resourceService, IOutpostService outpostService, IMapper mapper)
    {
        this.resourceService = resourceService;
        this.outpostService = outpostService;
        this.mapper = mapper;
    }

    /// <summary>
    /// Pobranie wszytskich produktów.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    public object Get(ResourceListRequest request)
    {
        var products = this.resourceService.GetAll();
        var data = this.mapper.Map<List<ResourceRecord>, ResourceData[]>(products);
        return data;
    }

    /// <summary>
    /// Pobranie pojedyńczego produktu.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    public object Get(ResourceGetRequest request)
    {
        var product = this.resourceService.Get(request.Id);

        if (product == null)
        {
            throw new NullReferenceException($"Couldn't find item with id {request.Id}");
        }

        var data = this.mapper.Map<ResourceRecord, ResourceData>(product);
        return data;
    }

    /// <summary>
    /// Dodanie noweg produktu do systemu.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    public object Any(ResourceCreateRequest request)
    {
        var validation = this.Request.TryResolve<IValidator<ResourceCreateRequest>>().Validate(request);

        if (!validation.IsValid)
        {
            throw new ValidationException($"Invalid object");
        }

        var outpost = this.outpostService.Get(request.OutpostId);

        if (outpost == null)
        {
            throw new NullReferenceException();
        }

        var builder = this.resourceService.Create()
            .Name(request.Name)
            .Quantity(request.Quantity)
            .ExpirationDate(request.ExpirationDate)
            .BuyDate(request.BuyDate)
            .Outpost(outpost);

        var record = this.resourceService.Save(builder);

        var data = this.mapper.Map<ResourceRecord, ResourceData>(record);
        return data;
    }
}