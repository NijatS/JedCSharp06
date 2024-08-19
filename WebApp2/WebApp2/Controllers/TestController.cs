using Microsoft.AspNetCore.Mvc;

namespace WebApp2.Controllers;

public class TestController : Controller
{
    // GET  Action 
    public IActionResult Index()
    {
        // return Json(new List<string>()
        // {
        //     "Nijat","Azima","Yusif"
        // });

        return View();
    }

    public IActionResult Detail()
    {
        return Json("Ders bitmek uzredir");
    }
    
}