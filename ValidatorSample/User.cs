// See https://aka.ms/new-console-template for more information
public class User
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public int Age { get; init; }
    public User(string firstName,string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
}
