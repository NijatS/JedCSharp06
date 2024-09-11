using CarRent.Models;

namespace CarRent.ViewModels;

public class HomeVM
{
    public ICollection<Slider> Sliders = new List<Slider>();
    public ICollection<Staff> Staves = new List<Staff>();
    public ICollection<Models.Service> Services = new List<Models.Service>();
}