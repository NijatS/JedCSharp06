using System.ComponentModel.DataAnnotations;

namespace MVCPostData.Models;

public class Person
{
    public int Id { get; set; }
    public  required string Name { get; set; }
    public required string Surname { get; set; }
    [Range(18,int.MaxValue,ErrorMessage = "Qardas senin surmeyine cox var, get xalcada sur")]
    public int Age { get; set; }
    public required string Specialty { get; set; }
    // [EmailAddress]
    [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$",ErrorMessage = "Qaqa guya sen agillisan?")]
    public required string Email { get; set; }
    public bool IsMarried { get; set; }
}