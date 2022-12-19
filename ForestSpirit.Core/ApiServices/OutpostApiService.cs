﻿using AutoMapper;
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
public class OutpostApiService : Controller
{
    /// <summary>
    /// Serwis produktów.
    /// </summary>
    private readonly IOutpostService outpostService;

    /// <summary>
    /// Silnik mapujący.
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// Initializes a new instance of the <see cref="OutpostApiService"/> class.
    /// </summary>
    /// <param name="outpostService">Serwis produktów.</param>
    /// <param name="mapper">Silnik mapujący.</param>
    public OutpostApiService(IOutpostService outpostService, IMapper mapper)
    {
        this.outpostService = outpostService;
        this.mapper = mapper;
    }

    /// <summary>
    /// Pobranie wszytskich produktów.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    [HttpGet]
    [Route("/api/workers/list")]
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
    [Route("/api/workers")]
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
    [Route("/api/customers/create")]
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