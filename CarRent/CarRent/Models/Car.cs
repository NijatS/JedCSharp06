using CarRent.Models.BaseEntities;
using CarRent.Models.Enums;

namespace CarRent.Models;

public class Car : BaseEntity
{
    public double Price { get; set; }
    public int NumberOfSeats { get; set; }
    public int BrandId { get; set; }
    public int BanId {get; set;}
    public DateOnly FactoryDate { get; set; }
    public Petrol Petrol { get; set; }
    public int Milage { get; set; }
    public GearBox GearBox { get; set; }
    public Ban Ban { get; set; }
    public Brand Brand { get; set; }
}