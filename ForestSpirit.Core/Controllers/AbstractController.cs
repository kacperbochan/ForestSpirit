using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestSpirit.Core.Controllers;

[ApiController]
public abstract class AbstractController : Controller
{
    /// <summary>
    /// Silnik mapujący.
    /// </summary>
    public readonly IMapper mapper;

    public AbstractController(IMapper mapper)
    {
        this.mapper = mapper;
    }
}
