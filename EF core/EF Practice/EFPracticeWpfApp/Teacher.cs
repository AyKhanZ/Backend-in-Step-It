using System;
using System.Collections.Generic;

namespace EFPracticeWpfApp;

public partial class Teacher
{
    public int Id { get; set; }

    public decimal? Salary { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public virtual ICollection<Lecture> Lectures { get; } = new List<Lecture>();
}
