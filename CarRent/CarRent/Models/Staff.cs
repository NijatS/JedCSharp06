using System.ComponentModel.DataAnnotations.Schema;
using CarRent.Models.BaseEntities;

namespace CarRent.Models;

public class Staff : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Profession { get; set; }
    public string FileName { get; set; }
    [NotMapped]
    public IFormFile File { get; set; }
}