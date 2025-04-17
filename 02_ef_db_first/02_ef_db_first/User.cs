namespace _02_ef_db_first;

internal class User
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int? Age { get; set; }
    public override string ToString()
    {
        return $"{Id} {Email} {Password} {Age}";
    }
}
