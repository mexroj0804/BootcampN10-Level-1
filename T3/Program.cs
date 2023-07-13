Console.Write("Enter username: ");
string username = Console.ReadLine();

Console.Write("Enter password: ");
string password = Console.ReadLine();

var email = "Dear {0}\nWe would like to inform you, that your password was changed. Your new password is {1}\nSincerely\nABC Team";
var email1 = string.Format(email, username, password);

Console.WriteLine(email1);