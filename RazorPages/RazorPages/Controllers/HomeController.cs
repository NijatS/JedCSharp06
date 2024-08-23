using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using RazorPages.Models;

namespace RazorPages.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        List<Person> people = new()
        {
            new()
            {
                Id = 1,
                Name = "Azima",
                Surname = "Qadirli",
                Age = 20
            },
            new()
            {
                Id = 2,
                Name = "Yusif",
                Surname = "Pirquliyev",
                Age = 22
            },
            new()
            {
                Id = 3,
                Name = "Nijat",
                Surname = "Soltanov",
                Age = 21
            },
            new()
            {
                Id = 4,
                Name = "Jesus",
                Surname = "Sadigov",
                Age = 28
            }
        };
        ViewBag.Edit = "Edit";
        ViewData["Remove"] = "Remove";

        var json = JsonSerializer.Serialize(people);

        TempData["Info"] = json;


        return View(people);
    }

    public IActionResult Detail()
    {
        var data = TempData["Info"];
        var people = JsonSerializer.Deserialize<List<Person>>(data.ToString());
        return View(people);
    }
    
}