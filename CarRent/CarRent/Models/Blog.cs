using System.ComponentModel.DataAnnotations.Schema;
using CarRent.Models.BaseEntities;

namespace CarRent.Models;

public class Blog : BaseEntity
{
    public string Title1 { get; set; }
    public string Description1 { get; set; }
    public string Title2 { get; set; }
    public string Description2 { get; set; }
    public string AuthorName { get; set; }
    public string AuthorDescription { get; set; }
    public string FileName { get; set; }
    public int CategoryId { get; set; }
    public string Paragraph { get; set; }
    public Category? Category { get; set; }
    public ICollection<BlogTag> BlogTags { get; set; }
    [NotMapped]
    public IFormFile File { get; set; }
 }