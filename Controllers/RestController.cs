using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _4d_dotnet.Models;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using NuGet.Common;

namespace _4d_dotnet.Controllers;

[Route("[controller]")]
public class RestController : ControllerBase
{

    [HttpGet]
    public IActionResult Index()
    {
        return Ok(DateTime.Now);
    }
}
