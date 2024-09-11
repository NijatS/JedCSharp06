using CarRent.Models;
using CarRent.Models.Account;
using CarRent.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CarRent.Areas.Admin.Controllers;

[Area("Admin")]
public class AccountController(IAccountService accountService) : Controller
{
    [HttpGet]
    public IActionResult Login()
    {
        if (User.Identity.IsAuthenticated)
        {
            return RedirectToAction("Index", "Home");
        }
        
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> Login(LoginModel model)
    {
        var response = await accountService.LoginAsync(model,false);
        if (!response.IsSuccess)
        {
            foreach (var error in response.Errors)
            {
                ModelState.AddModelError("", error);
            }
            return View(model);
        }
        
        return RedirectToAction("index","home");
    }

    public async Task<IActionResult> Logout()
    {
        await accountService.LogoutAsync();
        return RedirectToAction("index","home","default");
    }

    // public async Task<IActionResult> AddAdmin()
    // {
    //     var user = new AppUser()
    //     {
    //         Email = "superadmin@cental.az",
    //         FirstName = "SuperAdmin",
    //         LastName = "SuperAdmin",
    //         UserName = "SuperAdmin",
    //         EmailConfirmed = true,
    //     };
    //    await  _userManager.CreateAsync(user, "SuperAdmin123.");
    //    await _userManager.AddToRolesAsync(user,new List<string>{"Admin","SuperAdmin"});
    //    return Json("Yarandiiii");
    // }


    // public async Task<IActionResult> AddRole()
    // {
    //     var role1 = new IdentityRole()
    //     {
    //         Name = "Admin"
    //     };
    //     var role2 = new IdentityRole()
    //     {
    //         Name = "User"
    //     };
    //     var role3 = new IdentityRole()
    //     {
    //         Name = "SuperAdmin"
    //     };
    //     await _roleManager.CreateAsync(role1);
    //     await _roleManager.CreateAsync(role2);
    //     await _roleManager.CreateAsync(role3);
    //     return Json("Yarandiiii");
    // }
    
}