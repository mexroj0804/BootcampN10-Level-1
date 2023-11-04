using N38_HT1.Models;

var user = new List<User>()
{
    new User("Mexroj", "Xaybullayev", "mexroj007@gmail.com"),
    new User("Azizbek", "Abdurahmonov", "abdura52@gmail.com"),
    new User("John", "Doe", "jondoe@gmail.com"),
    new User("Jasur", "Akbarov", "jasurakbarov@gmail.com"),
    new User("Suxrob", "Olimov", "suxrobjon@gmail.com")
};

var container = new UsersContainer(user);
var query = container.Where(user => user.FirstName.Contains("xro"));

foreach (var item in query)
    Console.WriteLine(item);

Console.WriteLine();

Console.WriteLine(container[container.LastOrDefault().Id]);

Console.WriteLine(container[3]);

Console.WriteLine(container["o"]);


