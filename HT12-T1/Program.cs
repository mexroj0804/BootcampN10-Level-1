
User name1 = new User
{
    firstName = "Mexroj",
    lastName = "Xaybullayev",
    midname = "Mansurjonovich"
};

User name2 = new User
{
    firstName = "Mexroj",
    lastName = "Xaybullayev",
    midname = "Mansurjonovich"
};

Console.WriteLine(name1.Equals(name2));

public class User
{
    public string firstName;
    public string lastName;
    public string midname;
    public string fullName => $"{firstName} {lastName} {midname}";
    public override bool Equals(object? obj)
    {
        if (obj is User user)
            return this.GetHashCode() == user.GetHashCode();
        return false;
    }
    public override int GetHashCode()
    {
        return firstName.GetHashCode() 
            + lastName.GetHashCode()
            + midname.GetHashCode();
    }
}