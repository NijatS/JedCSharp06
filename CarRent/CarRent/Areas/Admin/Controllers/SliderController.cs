using System.Net;
using CarRent.Models;
using CarRent.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRent.Areas.Admin.Controllers;

[Area("Admin")]
public class SliderController : Controller
{
    private readonly IRepository<Slider> _repository;
    private readonly IWebHostEnvironment _webHostEnvironment;

    public SliderController(IRepository<Slider> repository,IWebHostEnvironment webHostEnvironment)
    {
        _repository = repository;
        _webHostEnvironment = webHostEnvironment;
    }

    // GET
    public async Task<IActionResult> Index()
    {
        var models = await _repository.GetAll().ToListAsync();
        return View(models);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Add(Slider Slider)
    {

        string fileName = Guid.NewGuid() +  Slider.File.FileName;

        string path = _webHostEnvironment.WebRootPath + "/images/sliders/" + fileName;

        using (FileStream stream = System.IO.File.Open(path, FileMode.Create))
        {
            await Slider.File.CopyToAsync(stream);
        };
        Slider.FileName = fileName;
        
        await _repository.AddAsync(Slider);
        await _repository.SaveAsync();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public async Task<IActionResult> Update(int id)
    {
        var data = await _repository.GetAsync(id);
        return View(data);
    }

    [HttpPost]
    public async Task<IActionResult> Update(int id, Slider Slider)
    {
        var updatedSlider = await _repository.GetAsync(id);

        updatedSlider.Title = Slider.Title;
        updatedSlider.Description = Slider.Description;

        if (Slider.File is not null)
        {
            string basePath = _webHostEnvironment.WebRootPath + "/images/sliders/";
            System.IO.File.Delete(basePath + updatedSlider.FileName);
            
            string fileName = Guid.NewGuid() +  Slider.File.FileName;
            string path = basePath + fileName;

            using (FileStream stream = System.IO.File.Open(path, FileMode.Create))
            {
                await Slider.File.CopyToAsync(stream);
            };
            updatedSlider.FileName = fileName;
        }

        _repository.Update(updatedSlider);
        await _repository.SaveAsync();
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> Remove(int id)
    {
        var Slider =  await _repository.GetAsync(id);
        _repository.Remove(Slider);
      
        System.IO.File.Delete(_webHostEnvironment.WebRootPath + "/images/sliders/" + Slider.FileName);
        await _repository.SaveAsync();
        return RedirectToAction("Index");
    }
}