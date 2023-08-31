using System.Text.RegularExpressions;



var email = new EmailService();

var email1 = EmailService.IsValidEmailAddress("mexroj009@gmail.coom");

Console.WriteLine(email1);

public class EmailService
{
    public static string? IsValidEmailAddress(string? emailAddress)
    {
        if (string.IsNullOrWhiteSpace(emailAddress) || (!Regex.IsMatch(emailAddress, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")))
            return "Email address is required.";

        if (emailAddress.Length < 5)
            return "Minimum length is 5";

        return null;
    }
}