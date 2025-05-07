
using Microsoft.EntityFrameworkCore;

namespace _08_attr_fluent_api;

internal class DbCtx : DbContext
{
    public DbSet<User> Users { get; set; }

    public DbCtx()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=p32_34_ef_attr_fluent_db;Trusted_Connection=True;Encrypt=False;");
    }

    protected override void OnModelCreating(ModelBuilder mb)
    {
        // mb.Entity<Role>();

        // mb.Entity<User>().Ignore(u => u.Token);

        // mb.Entity<User>().ToTable("clients");

        // mb.Entity<User>().Property(u => u.Id).HasColumnName("id");

        // mb.Entity<User>().Property(u => u.Age).IsRequired();

        // mb.Entity<User>().HasKey(u => u.Identity).HasName("PK_users_identity");

        // mb.Entity<User>().HasKey(u => new { u.Identity, u.Email });

        // mb.Entity<User>().HasAlternateKey(u => u.Email);

        // mb.Entity<User>().HasAlternateKey(u => new { u.Email, u.Age });

        // mb.Entity<User>().HasIndex(u => u.Email).IsUnique().HasDatabaseName("IX_users_email");

        // mb.Entity<User>().Property(u => u.Age).HasDefaultValue(18);

        // mb.Entity<User>().Property(u => u.CreatedAt).HasDefaultValueSql("GETDATE()");

        // mb.Entity<User>().Property(u => u.Email).HasMaxLength(64);
    }
}