using System.Linq.Expressions;
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

// IQueryable<User> users = db.Users.Where(u => u.Id > 1);
// users = users.Where(u => u.Age > 25);

// foreach(User user in users)
//    Console.WriteLine(user);



// List<User> users = db.Users.Where(u => u.Id > 1).ToList();
// foreach (User user in users)
//    Console.WriteLine(user);


// User user = db.Users.First(u => u.Id == 3);
// Console.WriteLine(user);



//using Db db = new Db();

////var users = db.Users
////            .AsEnumerable()
////            .Where(u => u.Age > 18);
//// SELECT * FROM users;
//// WHERE age > 18 в ооперативной памяти


//var users = db.Users
//            .Where(u => u.Age > 18);
//// SELECT * FROM users WHERE age > 18;
///




//using Db db = new Db();

////List<User> users = db.Users.ToList();

////Func<User, bool> filter = u => u.Age > 18;
////var result = users.Where(filter);


//Expression<Func<User, bool>> filter = u => u.Age > 18;

//var query = db.Users.Where(filter);



//using Db db = new Db();

//var q1 = db.Users
//            .Where(u => u.Age > 18)
//            .OrderBy(u => u.Age)
//            .ToList();
//// SELECT * FROM users WHERE age > 18 ORDER BY age;

//var q2 = db.Users
//            .Where(u => u.Age > 18)
//            .AsEnumerable()
//            .OrderBy(u => u.Age)
//            .ToList();
//// SELECT * FROM users WHERE age > 18;





//using Db db = new Db();

//var result = db.Users
//            .Where(u => u.Age > 18)
//            .AsEnumerable()
//            .Select(o => new
//            {
//                UserId = o.Id,
//                UserAge = o.Age
//            });



//using Db db = new Db();

//bool flag = true;

//Expression<Func<User, bool>> filter = u => u.Age > 18;

//var q1 = db.Users.Select(u => u);

//if (flag)
//    q1 = q1.Where(filter);
           

    



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





