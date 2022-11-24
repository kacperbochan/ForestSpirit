using AutoMapper;
using ForestSpirit.Framework.Products;
using ForestSpirit.Framework.Products.Records;
using ForestSpirit.ServiceModel.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace ForestSpirit.Core.Controllers;

[ApiController]
public class ProductController : Controller
{
    IProductService productService;
    IMapper mapper;
    public ProductController(IProductService productService,IMapper mapper)
    {
        this.productService = productService;
        this.mapper = mapper;
    }

    /// <summary>
    /// Dodanie noweg zlecenia do systemu.
    /// </summary>
    /// <param name="request">wartość rządania.</param>
    /// <returns>Odpowiedź.</returns>
    [HttpPost]
    [Route("/esb/maintenance/meter/created")]
    public object GetProducts()
    {
        var products = this.productService.GetAll();
        var data = this.mapper.Map<List<ProductRecord>, ProductData[]>(products);
        return data;
    }
}
