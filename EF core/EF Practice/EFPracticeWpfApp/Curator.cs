using System;
using System.Collections.Generic;

namespace EFPracticeWpfApp;

public partial class Curator
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public virtual ICollection<GroupsCurrator> GroupsCurrators { get; } = new List<GroupsCurrator>();
}
