using CarRent.Models.BaseEntities;

namespace CarRent.Models;

public class Model : BaseEntity
{
    public string Name { get; set; }
    public int BrandId { get; set; }
    public Brand? Brand { get; set; }
    public ICollection<Car>? Cars { get; set; } = new List<Car>();
}