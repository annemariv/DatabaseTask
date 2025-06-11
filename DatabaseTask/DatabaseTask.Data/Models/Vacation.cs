using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class Vacation
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public string? Type { get; set; }

    public int? VacationDaysTotal { get; set; }

    public string? Comments { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
