using CarRent.Models.Account;
using CarRent.Responses;

namespace CarRent.Services.Interfaces;

public interface IAccountService
{
    Task<Response> LoginAsync(LoginModel model,bool IsAdmin);
    Task<Response> RegisterAsync(RegisterModel model);
    Task LogoutAsync();
    Task<Response> ConfirmEmail(string userId, string token);
    Task<Response> ForgetPassword(ForgetPasswordModel model);
    Task<Response> ResetPassword(ResetPasswordModel model);
    Task<Response> Info(string userName);
}