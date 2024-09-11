using CarRent.Models;
using CarRent.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRent.Controllers;

public class ServiceController : Controller
{
    private readonly IRepository<Models.Service> _repository;

    public ServiceController(IRepository<Models.Service> repository)
    {
        _repository = repository;
    }

    // GET
    public async Task<IActionResult> Index()
    {
        var response = await _repository.GetAll().ToListAsync();
        return View(response);
    }
}