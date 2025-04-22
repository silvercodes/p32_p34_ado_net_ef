using _04_configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

// string connString = @"Server=.\SQLEXPRESS;Database=p32_34_ef_config_db;Trusted_Connection=True;Encrypt=False;";

//string configFile = "config.txt";
//using StreamReader reader = new StreamReader(configFile);
//string connString = reader.ReadToEnd();


//using Db db = new Db(connString);





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
DbContextOptions<Db> options =  builder.Options;

using Db db = new Db(options);
