using Microsoft.EntityFrameworkCore;

namespace _05_crud;

internal class Db: DbContext
{
    public DbSet<User> Users { get; set; }

    public Db()
    {
        // Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=p32_34_ef_crud_db;Trusted_Connection=True;Encrypt=False;");
    }
}
