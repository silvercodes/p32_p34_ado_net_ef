using System;
using System.Collections.Generic;

namespace _03_db_first.Models;

public partial class Pair
{
    public int Id { get; set; }

    public DateOnly PairDate { get; set; }

    public int ScheduleItemId { get; set; }

    public int SubjectId { get; set; }

    public bool IsOnline { get; set; }

    public int? ClassroomId { get; set; }

    public int TeacherId { get; set; }

    public virtual Classroom? Classroom { get; set; }

    public virtual ScheduleItem ScheduleItem { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;

    public virtual Teacher Teacher { get; set; } = null!;
}
