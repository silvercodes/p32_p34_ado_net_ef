using System;
using System.Collections.Generic;

namespace _03_db_first.Models;

public partial class Branch
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int CityId { get; set; }

    public virtual City City { get; set; } = null!;

    public virtual ICollection<Classroom> Classrooms { get; set; } = new List<Classroom>();
}
