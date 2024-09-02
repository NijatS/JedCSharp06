using CarRent.Models;
using CarRent.Repositories.Interfaces;
using CarRent.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRent.Controllers;

public class HomeController : Controller
{
    private readonly IRepository<Staff> _repository;
    private readonly IRepository<Slider> _sliderRepository;

    public HomeController(IRepository<Staff> repository, IRepository<Slider> sliderRepository)
    {
        _repository = repository;
        _sliderRepository = sliderRepository;
    }

    public async Task<ActionResult> Index()
    {

        HomeVM model = new()
        {
            Staves = await _repository.GetAll().Take(4).ToListAsync(),
            Sliders = await _sliderRepository.GetAll().ToListAsync()
        };
       
        return View(model);
    }
}