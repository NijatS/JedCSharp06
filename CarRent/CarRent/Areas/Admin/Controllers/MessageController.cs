using CarRent.Models;
using CarRent.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRent.Areas.Admin.Controllers;

[Area("Admin")]
public class MessageController : Controller
{
    private readonly IRepository<Message> _repository;

    public MessageController(IRepository<Message> repository)
    {
        _repository = repository;
    }

   [HttpGet]
   [Authorize(Roles = "SuperAdmin,Admin")]
    public async Task<IActionResult> Index()
    {
        var models = await _repository.GetAll().Include(x=>x.AppUser).ToListAsync();
        return View(models);
    }

    public async Task<ActionResult> Details(int id)
    {
        var result = await _repository.GetAll().Where(x => x.Id == id).Include(x=>x.AppUser).FirstOrDefaultAsync();
        if (result is null)
        {
            return Json(new { message = "Not found." });
        }
        return Json(result);
    }
    [Authorize(Roles = "SuperAdmin,Admin")]
    public async Task<IActionResult> Remove(int id)
    {
        await _repository.RemoveAsync(id);
        await _repository.SaveAsync();
        return RedirectToAction("Index");
    }
}