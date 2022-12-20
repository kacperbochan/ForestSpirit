using AutoMapper;

using ForestSpirit.Framework.Equipments;
using ForestSpirit.Framework.Equipments.Records;
using ForestSpirit.Framework.Outposts;
using ForestSpirit.ServiceModel.Equipments;

using Microsoft.AspNetCore.Mvc;

namespace ForestSpirit.Core.ApiServices;

/// <summary>
/// Serwis api produktów.
/// </summary>
[Route("/api/equipments")]
[ApiController]
public class EquipmentApiService : Controller
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
    public EquipmentApiService(IEquipmentService equimpentsService, IOutpostService outpostService, IMapper mapper)
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
    [HttpGet]
    [Route("/api/equipments/list")]
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
    [HttpGet]
    [Route("/api/equipments")]
    public object Get([FromQuery] int key)
    {
        var product = this.equimpentsService.Get(key);

        if (product == null)
        {
            throw new NullReferenceException($"Couldn't find item with id {key}");
        }

        var data = this.mapper.Map<EquipmentRecord, EquipmentData>(product);
        return data;
    }

    /// <summary>
    /// Dodanie noweg produktu do systemu.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    [HttpPost]
    [Route("/api/customers/create")]
    public object Any(EquipmentCreateRequest request)
    {
        /* var validation = this.Request.TryResolve<IValidator<EquipmentCreateRequest>>().Validate(request);

         if (!validation.IsValid)
         {
             throw new ValidationException($"Invalid object");
         }*/

        var outpost = this.outpostService.Get(request.OutpostId);

        if (outpost == null)
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