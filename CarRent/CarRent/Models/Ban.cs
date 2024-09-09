using CarRent.Models.BaseEntities;

namespace CarRent.Models;

public class Ban : BaseEntity
{
    public string Name { get; set; }
    public ICollection<Car>? Cars { get; set; } = new List<Car>();
}