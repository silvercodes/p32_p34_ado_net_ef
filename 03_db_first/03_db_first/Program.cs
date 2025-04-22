
using _03_db_first.Models;

using Db db = new Db();

City city = new City()
{
    Title = "city_1"
};
db.Cities.Add(city);

db.SaveChanges();
