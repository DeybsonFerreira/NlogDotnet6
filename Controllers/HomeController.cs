using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NlogDotnet6.Models;

namespace NlogDotnet6.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        _logger.LogDebug("MENSAGEM DE DEBUG");
        _logger.LogInformation("LOG DE INFORMAÇÃO");
        _logger.LogWarning("LOG DE WARNNING ");
        _logger.LogTrace("LOG DE UM TRACE");
        _logger.LogError(new Exception(), "LOG DE UM EXCEPTION");

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
