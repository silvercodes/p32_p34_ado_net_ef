using System.Xml;
using _05_crud;


// ==== CREATE

//using Db db = new Db();

//db.Users.AddRange(
//        new User() { Email = "email_1@mail.com", Password = "123123123", Age = 34 },
//        new User() { Email = "email_2@mail.com", Password = "123123123", Age = 23 },
//        new User() { Email = "email_3@mail.com", Password = "123123123", Age = 31 },
//        new User() { Email = "email_4@mail.com", Password = "123123123", Age = 20 }
//    );

//db.SaveChanges();


// ==== READ (GET)

// using Db db = new Db();

//IQueryable<User> users = db.Users.Where(u => u.Id > 1);
//users = users.Where(u => u.Age > 25);

//foreach(User user in users)
//    Console.WriteLine(user);



//List<User> users = db.Users.Where(u => u.Id > 1).ToList();
//foreach (User user in users)
//    Console.WriteLine(user);


//User user = db.Users.First(u => u.Id == 3);
//Console.WriteLine(user);




// ==== UPDATE

//using Db db = new Db();

//User user = db.Users.First(u => u.Id == 3);

//user.Email = "vasia@mail.com";
//user.Age = 40;

//db.SaveChanges();


//User? user = null;

//using (Db db = new Db())
//{
//    user = db.Users.First(u => u.Id == 3); 
//}

////
////

//using (Db db = new Db())
//{
//    user.Email = "petya@mail.com";

//    db.Update(user);
//    db.SaveChanges();
//}



// ==== DELETE

//using Db db = new Db();

//User user = db.Users.First(u => u.Id == 3);

//db.Users.Remove(user);

//db.SaveChanges();





