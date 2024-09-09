using Microsoft.AspNetCore.Identity;

namespace CarRent.Models;

public class AppUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public ICollection<Message> Messages { get; set; } = new List<Message>();
}