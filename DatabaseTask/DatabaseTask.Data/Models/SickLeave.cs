using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class SickLeave
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public DateOnly? StartingDate { get; set; }

    public DateOnly? EndingDate { get; set; }

    public string? Replacement { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
