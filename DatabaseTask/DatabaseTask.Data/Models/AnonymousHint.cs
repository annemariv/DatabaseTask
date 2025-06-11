using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class AnonymousHint
{
    public int Id { get; set; }

    public string? HintType { get; set; }

    public DateOnly? HintDate { get; set; }

    public string? Comment { get; set; }

    public int CompanyId { get; set; }

    public virtual Company Company { get; set; } = null!;
}
