using Microsoft.AspNetCore.Mvc;

namespace CarRent.Controllers;

public class ContactController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}