using CarRent.Models.BaseEntities;

namespace CarRent.Models;

public class Brand : BaseEntity
{
    public string Name { get; set; }
    public ICollection<Model> Models { get; set; } = new List<Model>();
}