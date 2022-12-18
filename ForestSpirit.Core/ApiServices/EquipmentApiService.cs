using AutoMapper;

using ForestSpirit.Framework.Equipments;
using ForestSpirit.Framework.Equipments.Records;
using ForestSpirit.Framework.Outposts;
using ForestSpirit.ServiceModel.Equipments;

using ServiceStack;
using ServiceStack.FluentValidation;

namespace ForestSpirit.Core.ApiServices;

/// <summary>
/// Serwis api produktów.
/// </summary>
public class EquipmentApiService : Service
{
    /// <summary>
    /// Serwis produktów.
    /// </summary>
    private readonly IEquipmentService equimpentsService;

    /// <summary>
    /// Serwis produktów.
    /// </summary>
    private readonly IOutpostService outpostService;

    /// <summary>
    /// Silnik mapujący.
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// Initializes a new instance of the <see cref="EquipmentApiService"/> class.
    /// </summary>
    /// <param name="equimpentsService">Serwis produktów.</param>
    /// <param name="mapper">Silnik mapujący.</param>
    public EquipmentApiService(IEquipmentService equimpentsService, IOutpostService outpostService,IMapper mapper)
    {
        this.equimpentsService = equimpentsService;
        this.outpostService = outpostService;
        this.mapper = mapper;
    }

    /// <summary>
    /// Pobranie wszytskich produktów.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    public object Get(EquipmentListRequest request)
    {
        var products = this.equimpentsService.GetAll();
        var data = this.mapper.Map<List<EquipmentRecord>, EquipmentData[]>(products);
        return data;
    }

    /// <summary>
    /// Pobranie pojedyńczego produktu.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    public object Get(EquipmentGetRequest request)
    {
        var product = this.equimpentsService.Get(request.Id);

        if (product == null)
        {
            throw new NullReferenceException($"Couldn't find item with id {request.Id}");
        }

        var data = this.mapper.Map<EquipmentRecord, EquipmentData>(product);
        return data;
    }

    /// <summary>
    /// Dodanie noweg produktu do systemu.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    public object Any(EquipmentCreateRequest request)
    {
        var validation = this.Request.TryResolve<IValidator<EquipmentCreateRequest>>().Validate(request);

        if (!validation.IsValid)
        {
            throw new ValidationException($"Invalid object");
        }

        var outpost = this.outpostService.Get(request.OutpostId);

        if(outpost == null)
        {
            throw new NullReferenceException();
        }

        var builder = this.equimpentsService.Create()
            .Name(request.Name)
            .SerialNumber(request.SerialNumber)
            .Outpost(outpost);

        var record = this.equimpentsService.Save(builder);

        var data = this.mapper.Map<EquipmentRecord, EquipmentData>(record);
        return data;
    }
}