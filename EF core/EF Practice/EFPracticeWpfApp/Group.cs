using System;
using System.Collections.Generic;

namespace EFPracticeWpfApp;

public partial class Group
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Year { get; set; }

    public int DepartmentId { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual ICollection<GroupsCurrator> GroupsCurrators { get; } = new List<GroupsCurrator>();

    public virtual ICollection<GroupsLecture> GroupsLectures { get; } = new List<GroupsLecture>();
}
