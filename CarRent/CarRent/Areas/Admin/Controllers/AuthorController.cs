using System.Net;
using CarRent.Models;
using CarRent.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRent.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "SuperAdmin,Admin")]
public class AuthorController : Controller
{
    private readonly IRepository<Author> _repository;
    private readonly IWebHostEnvironment _webHostEnvironment;

    public AuthorController(IRepository<Author> repository,IWebHostEnvironment webHostEnvironment)
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
    public async Task<IActionResult> Add(Author Author)
    {

        string fileName = Guid.NewGuid() +  Author.File.FileName;

        string path = _webHostEnvironment.WebRootPath + "/images/authors/" + fileName;

        using (FileStream stream = System.IO.File.Open(path, FileMode.Create))
        {
            await Author.File.CopyToAsync(stream);
        };
        Author.FileName = fileName;
        
        await _repository.AddAsync(Author);
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
    public async Task<IActionResult> Update(int id, Author Author)
    {
        var updatedAuthor = await _repository.GetAsync(id);

        updatedAuthor.Name = Author.Name;
        updatedAuthor.Description = Author.Description;

        if (Author.File is not null)
        {
            string basePath = _webHostEnvironment.WebRootPath + "/images/authors/";
            System.IO.File.Delete(basePath + updatedAuthor.FileName);
            
            string fileName = Guid.NewGuid() +  Author.File.FileName;
            string path = basePath + fileName;

            using (FileStream stream = System.IO.File.Open(path, FileMode.Create))
            {
                await Author.File.CopyToAsync(stream);
            };
            updatedAuthor.FileName = fileName;
        }

        _repository.Update(updatedAuthor);
        await _repository.SaveAsync();
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> Remove(int id)
    {
        var Author =  await _repository.GetAsync(id);
        _repository.Remove(Author);
      
        System.IO.File.Delete(_webHostEnvironment.WebRootPath + "/images/authors/" + Author.FileName);
        await _repository.SaveAsync();
        return RedirectToAction("Index");
    }
}