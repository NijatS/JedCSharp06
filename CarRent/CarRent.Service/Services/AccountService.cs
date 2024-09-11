using System.Security.Policy;
using CarRent.Models;
using CarRent.Models.Account;
using CarRent.Responses;
using CarRent.Services.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace CarRent.Services;

public class AccountService : IAccountService
{
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;

    public AccountService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }


    public async Task<Response> LoginAsync(LoginModel model, bool IsAdmin)
    {
        var user = await _userManager.FindByNameAsync(model.UserNameOrEmail);

        if (user is null)
        {
            user = await _userManager.FindByEmailAsync(model.UserNameOrEmail);

            if (user is null)
            {
                return new Response()
                {
                    IsSuccess = false,
                    Errors = new List<string>() { "Invalid username or password." }
                };
            }
        }
        
        if (!await _userManager.IsInRoleAsync(user, "Admin") && !await _userManager.IsInRoleAsync(user, "SuperAdmin") && IsAdmin)
        {
            return new Response()
            {
                IsSuccess = false,
                Errors = new List<string>() { "Invalid username or password." }
            };
        }

        if (!await _userManager.IsInRoleAsync(user, "User") && !IsAdmin)
        {
            return new Response()
            {
                IsSuccess = false,
                Errors = new List<string>() { "You do not have permission to access this page." }
            };
        }

        var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, true);

        if (!result.Succeeded)
        {
            return new Response()
            {
                IsSuccess = false,
                Errors = new List<string>() { "Invalid username or password." }
            };
        }

        return new Response()
        {
            IsSuccess = true,
        };
    }

    public async Task<Response> RegisterAsync(RegisterModel model)
    {
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
            return new Response()
            {
                IsSuccess = false,
                Errors = identityResult.Errors.Select(x=>x.Description).ToList()
            };
        }

        await _userManager.AddToRoleAsync(user, "User");
        
        var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);

        return new Response()
        {
            IsSuccess = true,
            Item = new
            {
                token,
                user
            }
        };
    }

    public async Task LogoutAsync()
    {
        await _signInManager.SignOutAsync();
    }

    public async Task<Response> ConfirmEmail(string userId, string token)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user is null)
        {
            return new Response()
            {
                IsSuccess = false,
            };
        }

        await _userManager.ConfirmEmailAsync(user, token);
        await _signInManager.SignInAsync(user, false);
        return new Response()
        {
            IsSuccess = true,
        };
    }

    public async Task<Response> ForgetPassword(ForgetPasswordModel model)
    {
        var user = await _userManager.FindByEmailAsync(model.Email);
        if (user is null)
        {
            return new Response()
            {
                IsSuccess = false,
            };
        }

        var token = await _userManager.GeneratePasswordResetTokenAsync(user);
        return new Response()
        {
            IsSuccess = true,
            Item = new
            {
                token,
                user
            }
        };
    }

    public async Task<Response> ResetPassword(ResetPasswordModel model)
    {
        var user = await _userManager.FindByIdAsync(model.UserId);
        if (user is null)
        {
            return new Response()
            {
                IsSuccess = false,
            };
        }

        IdentityResult result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);
        if (!result.Succeeded)
        {
            return new Response()
            {
                IsSuccess = false,
                Errors = result.Errors.Select(x => x.Description).ToList()
            };
        }

        return new Response()
        {
            IsSuccess = true,
        };
    }

    public async Task<Response> Info(string userName)
    {
        var user = await _userManager.FindByNameAsync(userName);
        return new Response()
        {
            IsSuccess = user is not null,
            Item = user
        };
    }
}