namespace _05_crud;

internal class User
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int Age { get; set; }
    public override string ToString()
    {
        return $"User STATE: {Id} {Email} {Password} {Age}";
    }
}
