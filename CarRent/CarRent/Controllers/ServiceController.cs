using Microsoft.AspNetCore.Mvc;

namespace CarRent.Controllers;

public class ServiceController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}