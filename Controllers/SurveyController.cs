using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using surveyjs_aspnet_mvc.Models;

namespace surveyjs_aspnet_mvc.Controllers;

public class SurveyController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IStorage _storage;

    public SurveyController(ILogger<HomeController> logger, IStorage storage)
    {
        _logger = logger;
        _storage = storage;
    }

    public IActionResult Index()
    {
        return View(new { Surveys = _storage.GetSurveys() });
    }

    public IActionResult Edit(string id)
    {
        return View(new { Survey = _storage.GetSurvey(id) });
    }

    public IActionResult Run(string id)
    {
        return View(new { Survey = _storage.GetSurvey(id) });
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
