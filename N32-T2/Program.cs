using N32_T2.Models;

var dastur = new ChatMassage(1, "a", "b", 2);
var dastur1 = new ChatMassage(1, "a", "ab", 2);

Console.WriteLine(dastur.GetHashCode());
Console.WriteLine(dastur1.GetHashCode());

Console.WriteLine(dastur.Equals(dastur1));

Console.WriteLine(dastur.ToString());
Console.WriteLine(dastur1.ToString());