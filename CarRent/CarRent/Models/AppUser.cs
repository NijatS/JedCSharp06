using Microsoft.AspNetCore.Identity;

namespace CarRent.Models;

public class AppUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}