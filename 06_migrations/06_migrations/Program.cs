using _06_migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

// 1. Get conn string from JSON file


ConfigurationBuilder cBuilder = new ConfigurationBuilder();
cBuilder.SetBasePath(Directory.GetCurrentDirectory());

cBuilder.AddJsonFile("MainConfig.json");
//
//

// 2. Build options
IConfigurationRoot config = cBuilder.Build();

string? connString = config.GetConnectionString("express");
Console.WriteLine(connString);

// 3. Create DbContext
DbContextOptionsBuilder<Db> builder = new DbContextOptionsBuilder<Db>();
builder.UseSqlServer(connString);
//
//
DbContextOptions<Db> options = builder.Options;


using Db db = new Db(options);
db.Database.Migrate();