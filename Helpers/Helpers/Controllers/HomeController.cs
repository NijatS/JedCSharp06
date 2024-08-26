using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Helpers.Models;

namespace Helpers.Controllers;

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
    
    public IActionResult Detail()
    {
        Student student = new()
        {
            StudentName = "Yusif"
        };
        
        ModelState.AddModelError("StudentId","ID bosdi");
        
        return View(student);
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