using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class Kid
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
