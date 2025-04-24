using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace _06_migrations;

internal class ConfigFactory : IDesignTimeDbContextFactory<Db>
{
    public Db CreateDbContext(string[] args)
    {
        ConfigurationBuilder cBuilder = new ConfigurationBuilder();
        cBuilder.SetBasePath(Directory.GetCurrentDirectory());

        cBuilder.AddJsonFile("MainConfig.json");
        IConfigurationRoot config = cBuilder.Build();

        string? connString = config.GetConnectionString("express");

        DbContextOptionsBuilder<Db> builder = new DbContextOptionsBuilder<Db>();
        builder.UseSqlServer(connString);
        DbContextOptions<Db> options = builder.Options;

        return new Db(options);
    }
}
