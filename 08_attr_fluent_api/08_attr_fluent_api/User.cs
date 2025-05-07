using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using _08_attr_fluent_api;
using Microsoft.EntityFrameworkCore;

//internal class User
//{
//    public int Id { get; set; }
//    public string Email { get; set; }
//    public string Password { get; set; }
//    public int Age { get; set; }
//    public Role? Role { get; set; }

//}



//internal class User
//{
//    private int age;
//    public int Id { get; set; }
//    public string Email { get; set; }
//    public string Password { get; set; }
//    public int Age
//    {
//        get => age;
//        set
//        {
//            age = value >= 18 ? value : 18;
//        }
//    }
//    // [NotMapped]
//    public string Token { get; set; }
//}





//internal class User
//{
//    public int Id { get; set; }
//    public string Email { get; set; }
//    public int Age { get; set; }

//    public User(string email)
//    {
//        Email = email.ToLower();
//    }
//}



// [Table("clients")]
//internal class User
//{
//    // [Column("id")]
//    public int Id { get; set; }
//    public string Email { get; set; }
//    public int Age { get; set; }
//}




//internal class User
//{
//    public int Id { get; set; }
//    public string Email { get; set; }
//    // [Required]
//    public int? Age { get; set; }
//}



//internal class User
//{
//    // [Key]
//    public int Identity { get; set; }
//    public string Email { get; set; }
//    public int? Age { get; set; }
//}




// [Index("Email", "Age")]
// [Index("Email", IsUnique = true, Name = "IX_users_email")]
//internal class User
//{
//    public int Id { get; set; }
//    public string Email { get; set; }
//    public int Age { get; set; }
//    public DateTime CreatedAt { get; set; }
//}



[EntityTypeConfiguration(typeof(UserConfiguration))]
internal class User
{
    public int Id { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
    public DateTime CreatedAt { get; set; }
}

