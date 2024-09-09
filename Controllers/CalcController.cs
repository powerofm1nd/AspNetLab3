using Microsoft.AspNetCore.Mvc;
using WebApplicationLab3.Services;

namespace WebApplicationLab3.Controllers;

public class CalcController : Controller
{
    ICalcService _calcService;
    
    public CalcController(ICalcService calcService)
    {
        _calcService = calcService;
    }
    
    // GET
    public IActionResult Index(int a, int b)
    {
        return View();
    }

    public string Add(int a, int b)
    {
        return _calcService.Add(a, b).ToString();
    }
    
    public string Subtract(int a, int b)
    {
        return _calcService.Subtract(a, b).ToString();
    }
}