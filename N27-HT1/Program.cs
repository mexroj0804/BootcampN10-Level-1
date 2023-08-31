

using N27_HT1.Services;

var dastur = new UserService();
dastur.GetUsers().ForEach(user => Console.WriteLine($"{user.EmailAdress} - {user.Password} -- Is Admin - {user.IsAdmin}"));

dastur.Add("abdura52@gmail.com", "abdura52");
Console.WriteLine();

dastur.GetUsers().ForEach(user => Console.WriteLine($"{user.EmailAdress} - {user.Password} -- Is Admin - {user.IsAdmin}"));