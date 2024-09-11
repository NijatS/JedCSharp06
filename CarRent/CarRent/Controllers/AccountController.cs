using CarRent.Models;
using CarRent.Models.Account;
using CarRent.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CarRent.Controllers;

public class AccountController(IMailService mailService,IAccountService accountService) : Controller
{

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(RegisterModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var response = await accountService.RegisterAsync(model);
        
        if (!response.IsSuccess)
        {
            foreach (var error in response.Errors)
            {
                ModelState.AddModelError("", error);
            }

            return View(model);
        }
        
        var item = (dynamic)response.Item;
        
        var link = Url.Action("ConfirmEmail", "Account", new
            {
                userId = item.user.Id, token = item.token
            }, protocol: HttpContext.Request.Scheme
        );

        mailService.SendMail(item.user.Email, "Verify Email", $"Please click this link {link} to verify your email");

        return RedirectToAction("Index", "Home");
    }

    [HttpGet]
    public IActionResult Login()
    {
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
        return RedirectToAction("Index", "Home");
    }

    public async Task<IActionResult> Logout()
    {
        await accountService.LogoutAsync();
        return RedirectToAction("Index", "Home");
    }

    public async Task<IActionResult> ConfirmEmail(string userId, string token)
    {
        var response = await accountService.ConfirmEmail(userId, token);
        if (!response.IsSuccess)
        {
            return NotFound();
        }
        return RedirectToAction("Index", "Home");
    }

    [HttpGet]
    public IActionResult ForgetPassword()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> ForgetPassword(ForgetPasswordModel model)
    {
        var response = await accountService.ForgetPassword(model);
        var item = (dynamic)response.Item;
   
        var link = Url.Action("ResetPassword", "Account", new { userId = item.user.Id, token = item.token },
            protocol: HttpContext.Request.Scheme);

        mailService.SendMail(item.user.Email, "Reset Password", $"Please click this link {link} to reset your password");
        return RedirectToAction("Index", "Home");
    }

    [HttpGet]
    public IActionResult ResetPassword(string userId, string token)
    {
        ResetPasswordModel model = new ResetPasswordModel()
        {
            UserId = userId,
            Token = token
        };

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }
        var response = await accountService.ResetPassword(model);
        if (!response.IsSuccess)
        {
            foreach (var error in response.Errors)
            {
                ModelState.AddModelError("", error);
            }
            return View(model);
        }
        
        return RedirectToAction("login", "account");
    }

    [HttpGet]
    [Authorize(Roles = "User")]
    public async Task<IActionResult> Info()
    {
        var response = await accountService.Info(User.Identity.Name);
        if (!response.IsSuccess)
        {
            return BadRequest();
        }
        return View(response.Item);
    }
}