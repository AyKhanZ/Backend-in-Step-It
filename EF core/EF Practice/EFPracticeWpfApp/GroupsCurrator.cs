using System;
using System.Collections.Generic;

namespace EFPracticeWpfApp;

public partial class GroupsCurrator
{
    public int Id { get; set; }

    public int CuratorId { get; set; }

    public int GroupId { get; set; }

    public virtual Curator Curator { get; set; } = null!;

    public virtual Group Group { get; set; } = null!;
}
