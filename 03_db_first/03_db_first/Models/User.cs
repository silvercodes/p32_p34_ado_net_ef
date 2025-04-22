using System;
using System.Collections.Generic;

namespace _03_db_first.Models;

public partial class User
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string Hash { get; set; } = null!;

    public DateTime? DeletedAt { get; set; }

    public int RoleId { get; set; }

    public virtual Role Role { get; set; } = null!;

    public virtual Teacher? Teacher { get; set; }
}
