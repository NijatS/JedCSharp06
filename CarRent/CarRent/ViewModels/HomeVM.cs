using CarRent.Models;

namespace CarRent.ViewModels;

public class HomeVM
{
    public ICollection<Slider> Sliders = new List<Slider>();
    public ICollection<Staff> Staves = new List<Staff>();
    public ICollection<Service> Services = new List<Service>();
}