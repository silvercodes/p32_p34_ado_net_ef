using Microsoft.EntityFrameworkCore;

namespace _04_configuration;

internal class Db: DbContext
{
    //public string? ConnString { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }

    #region simple

    //public Db(string? connString)
    //{
    //    ConnString = connString;

    //    Database.EnsureDeleted();
    //    Database.EnsureCreated();
    //}

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    if (ConnString is null)
    //        throw new ArgumentNullException("Invalid connection string");

    //    optionsBuilder.UseSqlServer(ConnString);
    //}

    #endregion

    #region Options to DbContext

    public Db(DbContextOptions<Db> options):
        base(options)
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    #endregion



}
