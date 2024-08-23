using Microsoft.AspNetCore.Mvc;

namespace CarRent.Controllers;

public class ShopController : Controller
{

    public IActionResult Index()
    {
        return View();
    }
}