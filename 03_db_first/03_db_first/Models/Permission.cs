using System;
using System.Collections.Generic;

namespace _03_db_first.Models;

public partial class Permission
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Slug { get; set; } = null!;

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
}
