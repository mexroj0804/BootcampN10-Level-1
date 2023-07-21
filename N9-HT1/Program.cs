using System.Text.RegularExpressions;

var emails = new List<string>();
emails.Add("mexrojxaybullayev@gmail.com");
emails.Add("azizbek.gmail.com");
emails.Add("teshavoy@gmail..com");
emails.Add("qoravooyg@gmail.com");
emails.Add("yebtoymas.@gmai.com.");

var emailAddressRegex = new Regex("^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\\.[a-zA-Z0-9]+$");

var emailAddress = string.Empty;
for (int i = 0; i < emails.Count; i++)
{
    emailAddress = emails[i];
    if (emailAddressRegex.IsMatch(emailAddress) == true)
        Console.WriteLine($"{emailAddress} - Yaroqli!");
    else
        Console.WriteLine($"{emailAddress} - Yaroqsiz!");
}