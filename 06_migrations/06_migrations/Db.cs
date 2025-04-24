using Microsoft.EntityFrameworkCore;

namespace _06_migrations;

internal class Db:DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }

    public Db(DbContextOptions<Db> options) :
        base(options)
    {
        Database.CanConnect();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=p32_ef_migrations_db;Trusted_Connection=True;Encrypt=False;");
    }
}
