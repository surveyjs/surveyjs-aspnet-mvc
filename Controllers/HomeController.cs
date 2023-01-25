using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using surveyjs_aspnet_mvc.Models;

namespace surveyjs_aspnet_mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IStorage _storage;

    public HomeController(ILogger<HomeController> logger, IStorage storage)
    {
        _logger = logger;
        _storage = storage;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult MySurveys()
    {
        return View(new { Surveys = _storage.GetSurveys() });
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
