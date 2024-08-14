namespace ORMConfiguration.Models;

public class Car
{
    public string VinCode { get; set; }
    public string EngineNumber { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int HP { get; set; }
    public bool IsNew { get; set; }
    public double Price { get; set; }
    public double Engine { get; set; }
}