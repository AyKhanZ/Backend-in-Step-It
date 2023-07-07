using System;
using System.Collections.Generic;

namespace EFPracticeWpfApp;

public partial class Department
{
    public int Id { get; set; }

    public decimal Financing { get; set; }

    public string Name { get; set; } = null!;

    public int FacultyId { get; set; }

    public virtual Faculty Faculty { get; set; } = null!;

    public virtual ICollection<Group> Groups { get; } = new List<Group>();
}
