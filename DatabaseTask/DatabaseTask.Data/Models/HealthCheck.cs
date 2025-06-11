using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class HealthCheck
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public DateOnly? CheckDate { get; set; }

    public string? Comments { get; set; }

    public bool? IsChecked { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
