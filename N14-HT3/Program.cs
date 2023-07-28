using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

// Ustoz name va phone uchun tashlagan regex laringiz ishlamayapti menda!!!!

Validator dastur = new Validator();
dastur.IsValidName("Mexroj", "Xaybullayev", "Mansurjonovich");
dastur.IsValidEmailAdress("mexrojxaybullayev@gmail.com");
dastur.IsValidPhoneNumber("+998-94-701-08-04");

public class Validator      //        "^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\\.[a-zA-Z0-9]+$"
{
    protected Regex fish = new Regex("^[a - zA - Z]+$");
    protected Regex emal = new Regex("^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\\.[a-zA-Z0-9]{2,}$");
    protected Regex phone = new Regex("^\\+?\\d{1,3}?[-.\\s]?\\?\\d{1,4}\\?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$");

    public void IsValidName(string name, string firstName, string midlename)
    {
        Console.WriteLine($"Name: {name} is {fish.IsMatch(name)}");
        Console.WriteLine($"Firstname: {firstName} is {fish.IsMatch(firstName)}");
        Console.WriteLine($"Midlename: {midlename} is {fish.IsMatch(midlename)}");
    }

    public void IsValidEmailAdress(string emailAdress)
    {
        Console.WriteLine($"EmailAdress: {emailAdress} is {emal.IsMatch(emailAdress)}");
    }

    public void IsValidPhoneNumber(string phoneNumber)
    {
        Console.WriteLine($"Phonenumber: {phoneNumber} is {phone.IsMatch(phoneNumber)}");
    }
}