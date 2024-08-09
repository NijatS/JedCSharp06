using System;
using System.Collections.Generic;

namespace ORM.Entities;

public partial class Patient
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public int? Age { get; set; }
}
