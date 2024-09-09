using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplicationLab3.Models;
using WebApplicationLab3.Services;

namespace WebApplicationLab3.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ITimeService _timeService;

    public HomeController(ILogger<HomeController> logger, ITimeService timeService)
    {
        _logger = logger;
        _timeService = timeService;
    }

    public IActionResult Index()
    {
        ViewData["TimeOfDay"] = _timeService.GetTimeOfDay();
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
