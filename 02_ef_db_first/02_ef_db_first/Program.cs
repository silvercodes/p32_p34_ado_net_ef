using _02_ef_db_first;

using Db db = new Db();

//User u1 = new User() { Email = "vasia@mail.com", Password = "123123123", Age = 23 };
//User u2 = new User() { Email = "petya@mail.com", Password = "123123123", Age = 34 };

//Console.WriteLine(u1);
//Console.WriteLine(u2);

//db.Users.AddRange(u1, u2);

//db.SaveChanges();

//Console.WriteLine(u1);
//Console.WriteLine(u2);


User u = db.Users.First(u => u.Id == 2);
Console.WriteLine(u);
