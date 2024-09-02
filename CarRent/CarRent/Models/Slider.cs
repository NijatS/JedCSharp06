using System.ComponentModel.DataAnnotations.Schema;
using CarRent.Models.BaseEntities;

namespace CarRent.Models;

public class Slider : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string FileName { get; set; }
    [NotMapped]
    public IFormFile File { get; set; }
}