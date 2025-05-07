
User a = new User("vasia@mail.com", "123123123");
Console.WriteLine(a.ValidateEmail());


[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
class PassLengthAttribute: Attribute
{
    public int Len { get; }
    public PassLengthAttribute(int len) => Len = len;
}


[PassLength(20)]
class User
{
    public string Email { get; set; }
    public string Password { get; set; }
    public User(string email, string password)
    {
        Email = email;
        Password = password;
    }
    public bool ValidateEmail()
    {
        Type t = typeof(User);

        object[] attributes = t.GetCustomAttributes(false);

        foreach (object attr in attributes)
        {
            if (attr is PassLengthAttribute pla)
            {
                if (Password.Length < pla.Len)
                    return false;
            }
        }

        return true;
    }
}
