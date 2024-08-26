using System.ComponentModel.DataAnnotations;

namespace Helpers.Models;

public class Student
{
    public int StudentId { get; set; }
    [Display(Name="Name")]
    public string StudentName { get; set; }
    public bool isActive { get; set; }
    public string Gender { get; set; }
}