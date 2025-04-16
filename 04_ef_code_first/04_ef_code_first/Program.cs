
using _04_ef_code_first;

// using Db db = new Db();

//Product p1 = new Product() { Title = "table", Description = "Best table", Price = 5000 };
//Product p2 = new Product() { Title = "apple", Description = "Best apple", Price = 10 };

//Console.WriteLine(p1);
//Console.WriteLine(p2);

//db.Products.AddRange(p1, p2);

//db.SaveChanges();

//Console.WriteLine(p1);
//Console.WriteLine(p2);





Db db = new Db();

Product p = db.Products.First(p => p.Id == 2);
Console.WriteLine(p);


