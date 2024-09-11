using CarRent.Models.BaseEntities;

namespace CarRent.Models;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public ICollection<Blog>? Blogs { get; set; }
    
}