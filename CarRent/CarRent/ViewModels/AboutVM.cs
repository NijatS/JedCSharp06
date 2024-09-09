using CarRent.Models;

namespace CarRent.ViewModels;

public class AboutVM
{
    public ICollection<Staff> Staves { get; set; } = new List<Staff>();
}