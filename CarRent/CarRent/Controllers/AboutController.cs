using Microsoft.AspNetCore.Mvc;

namespace CarRent.Controllers;

public class AboutController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}