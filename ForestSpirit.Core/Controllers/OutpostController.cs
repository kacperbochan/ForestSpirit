using AutoMapper;
using ForestSpirit.Core.Controllers;
using ForestSpirit.Framework.Outposts;
using ForestSpirit.Framework.Outposts.Records;
using ForestSpirit.ServiceModel.Outposts;
using Microsoft.AspNetCore.Mvc;

namespace ForestSpirit.Core.ApiServices;

/// <summary>
/// Serwis api produktów.
/// </summary>
[Route("/api/outposts")]
[ApiController]
public class OutpostController : AbstractController
{
    /// <summary>
    /// Serwis produktów.
    /// </summary>
    private readonly IOutpostService outpostService;

    /// <summary>
    /// Initializes a new instance of the <see cref="OutpostController"/> class.
    /// </summary>
    /// <param name="outpostService">Serwis produktów.</param>
    /// <param name="mapper">Silnik mapujący.</param>
    public OutpostController(IOutpostService outpostService, IMapper mapper)
        : base(mapper)
    {
        this.outpostService = outpostService;
    }

    /// <summary>
    /// Pobranie wszytskich produktów.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    [HttpGet]
    [Route("/api/outposts/list")]
    public object Get(OutpostListRequest request)
    {
        var products = this.outpostService.GetAll();
        var data = this.mapper.Map<List<OutpostRecord>, OutpostData[]>(products);
        return data;
    }

    /// <summary>
    /// Pobranie pojedyńczego produktu.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    [HttpGet]
    [Route("/api/outposts")]
    public object Get([FromQuery] int key)
    {
        var product = this.outpostService.Get(key);

        if (product == null)
        {
            throw new NullReferenceException($"Couldn't find item with id {key}");
        }

        var data = this.mapper.Map<OutpostRecord, OutpostData>(product);
        return data;
    }

    /// <summary>
    /// Dodanie noweg produktu do systemu.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    [HttpPost]
    [Route("/api/outposts/create")]
    public object Any(OutpostCreateRequest request)
    {
        /*var validation = this.Request.TryResolve<IValidator<OutpostCreateRequest>>().Validate(request);

        if (!validation.IsValid)
        {
            throw new ValidationException($"Invalid object");
        }
*/
        var builder = this.outpostService.Create()
            .Name(request.Name)
            .Latitude(request.Latitude)
            .Longitude(request.Longitude);

        var record = this.outpostService.Save(builder);

        var data = this.mapper.Map<OutpostRecord, OutpostData>(record);
        return data;
    }
}