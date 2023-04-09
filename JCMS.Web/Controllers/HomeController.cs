using JCMS.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Data;
using System.Diagnostics;
namespace JCMS.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult WhoisWho()
    {
        return View();
    }
    public IActionResult PublicUtilities()
    {
        return View();
    }
    public IActionResult About()
    {
        return View();
    }
    public IActionResult Demography()
    {
        return View();
    }
    public IActionResult Documents()
    {
        return View();
    }
    public IActionResult Mission()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Tender()
    {
        return View();
    }
    public IActionResult Announcement()
    {
        return View();
    }
    public IActionResult Notice()
    {
        return View();
    }
    public IActionResult Advertisement()
    {
        return View();
    }

    [Route("Programme/{id}")]
    public IActionResult Programme(int id)
    {
        ViewBag.id = id;
        return View();
    }
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    public IActionResult WardOfficer()
    {
        return View();
    }
    public IActionResult Counciler()
    {
        return View();
    }
    public IActionResult Executiveofficer()
    {
        return View();
    }
    public IActionResult Chairman()
    {
        return View();
    }
    [Route("RTI")]
    public IActionResult RTI()
    {
        return View();
    }
    [Route("News")]
    public IActionResult News()
    {
        return View();
    }

    

}
