﻿using AutoMapper;

using ForestSpirit.Core.Controllers;
using ForestSpirit.Framework.Products;
using ForestSpirit.Framework.Products.Providers;
using ForestSpirit.Framework.Products.Records;
using ForestSpirit.ServiceModel.Products;

using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ForestSpirit.Core.ApiServices;

/// <summary>
/// Serwis api produktów.
/// </summary>
[Route("/api/products")]
[ApiController]
public class ProductController : AbstractController
{
    /// <summary>
    /// Serwis produktów.
    /// </summary>
    private readonly IProductService productService;

    /// <summary>
    /// Initializes a new instance of the <see cref="ProductController"/> class.
    /// </summary>
    /// <param name="productService">Serwis produktów.</param>
    /// <param name="mapper">Silnik mapujący.</param>
    public ProductController(IProductService productService, IMapper mapper)
        : base(mapper)
    {
        this.productService = productService;
    }

    /// <summary>
    /// Pobranie wszytskich produktów.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    [EnableCors]
    [HttpGet]
    [Route("/api/products/list")]
    public IActionResult Get()
    {
        var products = this.productService.GetAll();
        var data = this.mapper.Map<List<ProductRecord>, ProductData[]>(products);
        return Ok(data);
    }

    /// <summary>
    /// Pobranie wszytskich produktów.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    [EnableCors]
    [HttpGet]
    [Route("/api/products/search")]
    public IActionResult Search(ProductSearchRequest request)
    {
        var products = this.productService.GetAll();

        products = this.Filter(products, request);

        var data = this.mapper.Map<List<ProductRecord>, ProductData[]>(products);
        return Ok(data);
    }

    private List<ProductRecord> Filter(List<ProductRecord> items, ProductSearchRequest filter)
    {
        if (filter.Keys.Count() != 0)
        {
            items = items.Where(x => filter.Keys.Contains(x.Id)).ToList();
        }

        if (filter.Category.Count() != 0)
        {
            items = items.Where(x => filter.Category.Contains(x.Id)).ToList();
        }

        if (filter.HiPrice != null)
        {
            items = items.Where(x => x.Price < filter.HiPrice).ToList();
        }

        if (filter.LoPrice != null)
        {
            items = items.Where(x => x.Price > filter.LoPrice).ToList();
        }

        if (filter.Skip != null)
        {
            items.Skip((int)filter.Skip);
        }

        if (filter.Take != null)
        {
            items.Skip((int)filter.Take);
        }

        return items;
    }

    /// <summary>
    /// Pobranie pojedyńczego produktu.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    [EnableCors]
    [HttpGet]
    [Route("/api/products/get")]
    public IActionResult Get([FromQuery] int key)
    {
        var product = this.productService.Get(key);

        if (product == null)
        {
            throw new NullReferenceException($"Couldn't find item with id {key}");
        }

        var data = this.mapper.Map<ProductRecord, ProductData>(product);
        return Ok(data);
    }

    /// <summary>
    /// Dodanie noweg produktu do systemu.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    [EnableCors]
    [HttpPost]
    [Route("/api/products/create")]
    public IActionResult Any(ProductCreateRequest request)
    {
        /*var validation = this.Request.TryResolve<IValidator<ProductCreateRequest>>().Validate(request);

        if (!validation.IsValid)
         {
             throw new ValidationException($"Invalid object");
         }*/

        var builder = this.productService.Create()
            .Name(request.Name)
            .Procentage(request.Procentage)
            .Price(request.Price);

        var record = this.productService.Save(builder);

        var data = this.mapper.Map<ProductRecord, ProductData>(record);
        return Ok(data);
    }

    /// <summary>
    /// Dodanie noweg produktu do systemu.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    [EnableCors]
    [HttpPost]
    [Route("/api/products/update")]
    public IActionResult Any([FromQuery] int key, [FromBody] ProductUpdateRequest request)
    {
        //var validation = this.Request.TryResolve<IValidator<ProductCreateRequest>>().Validate(request);

        /* if (!validation.IsValid)
         {
             throw new ValidationException($"Invalid object");
         }*/

        var product = this.productService.Get(key);

        var builder = this.productService.Update(product)
            .Name(request.Name)
            .Procentage(request.Procentage)
            .Price(request.Price);

        var record = this.productService.Save(builder);

        var data = this.mapper.Map<ProductRecord, ProductData>(record);
        return this.Ok(data);
    }

    /// <summary>
    /// Dodanie noweg produktu do systemu.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    [EnableCors]
    [HttpGet]
    [Route("/api/products/tastes")]
    public IActionResult GetTastes()
    {
        return this.Ok(this.productService.GetTastes());
    }

    /// <summary>
    /// Dodanie noweg produktu do systemu.
    /// </summary>
    /// <param name="request">Wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    [EnableCors]
    [HttpGet]
    [Route("/api/products/categories")]
    public IActionResult GetCategories()
    {
        return this.Ok(ProductCategories.Instance.GetData());
    }
}