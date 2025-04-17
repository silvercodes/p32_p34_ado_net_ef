using Microsoft.EntityFrameworkCore;

namespace _02_ef_db_first;

internal class Db: DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }

    public Db()
    {
        // Database.EnsureDeleted();
        Database.EnsureCreated();
        Database.CanConnect();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=p32_ef_code_first_db;Trusted_Connection=True;Encrypt=False;");
    }

}
