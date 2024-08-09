using System;
using System.Collections.Generic;

namespace ORM.Entities;

public partial class Doctor
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Email { get; set; }

    public string? Specialty { get; set; }
}
