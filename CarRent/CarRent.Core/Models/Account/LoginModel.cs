namespace CarRent.Models.Account;

public class LoginModel
{
    public string UserNameOrEmail { get; set; }
    public string Password { get; set; }
    public bool RememberMe { get; set; }
}