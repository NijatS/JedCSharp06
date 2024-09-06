using CarRent.Models;
using CarRent.Models.Account;
using CarRent.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CarRent.Controllers;

public class AccountController : Controller
{
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;
    private readonly IMailService _mailService;

    public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,
        IMailService mailService)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _mailService = mailService;
    }

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

        AppUser user = new AppUser()
        {
            Email = model.Email,
            UserName = model.Username,
            FirstName = model.FirstName,
            LastName = model.LastName,
        };

        var identityResult = await _userManager.CreateAsync(user, model.Password);

        if (!identityResult.Succeeded)
        {
            foreach (var error in identityResult.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View(model);
        }

        await _userManager.AddToRoleAsync(user, "User");
        
        var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);

        var link = Url.Action("ConfirmEmail", "Account", new
            {
                userId = user.Id, token = token
            },protocol: HttpContext.Request.Scheme
        );

        _mailService.SendMail(user.Email, "Verify Email",$"Please click this link {link} to verify your email");


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
        var user = await _userManager.FindByNameAsync(model.UserNameOrEmail);

        if (user is null)
        {
            user = await _userManager.FindByEmailAsync(model.UserNameOrEmail);

            if (user is null)
            {
                ModelState.AddModelError("", "Invalid username or password.");
                return View(model);
            }
        }

        if (!await _userManager.IsInRoleAsync(user, "User"))
        {
            ModelState.AddModelError("", "You do not have permission to access this page.");
            return View(model);
        }

        var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, true);

        if (!result.Succeeded)
        {
            ModelState.AddModelError("", "Invalid username or password.");
            return View(model);
        }

        return RedirectToAction("Index", "Home");
    }

    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        return RedirectToAction("Index", "Home");
    }

    public async Task<IActionResult> ConfirmEmail(string userId, string token)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user is null)
        {
           return NotFound();
        }
        await _userManager.ConfirmEmailAsync(user, token);
        await _signInManager.SignInAsync(user, false);
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
        var user = await _userManager.FindByEmailAsync(model.Email);
        if (user is null)
        {
            return RedirectToAction("Index", "Home");
        }
        
        var token = await _userManager.GeneratePasswordResetTokenAsync(user);   
        var link = Url.Action("ResetPassword", "Account", new{userId = user.Id, token = token}, protocol: HttpContext.Request.Scheme);
        
        _mailService.SendMail(user.Email, "Reset Password",$"Please click this link {link} to reset your password");
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
        
        var user = await _userManager.FindByIdAsync(model.UserId);
        if (user is null)
        {
            return NotFound();
        }
        
        IdentityResult result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);
        if (!result.Succeeded)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
            return View(model);
        }
        return RedirectToAction("login", "account");
    }

    [HttpGet]
    [Authorize(Roles ="User" )]
    public async Task<IActionResult> Info()
    {
      var user = await  _userManager.FindByNameAsync(User.Identity.Name);
      return View(user);
    }
    
}