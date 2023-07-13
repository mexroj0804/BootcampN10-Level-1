using System.Xml;

Console.Write("Ismingizni kiriting:");
string ism = Console.ReadLine();

Console.Write("Familyangizni kiriting:");
String familya = Console.ReadLine();

Console.Write("Yoshingizni kiriting:");
int yosh  = int.Parse(Console.ReadLine());

Console.Write("2 + 4 = ");
int natija = int.Parse(Console.ReadLine());

var string1 = ("Ism:{0}\nFamilya{1}\nYosh:{2}\nNatija:{3}");
var string2 = string.Format(string1, ism, familya, yosh, natija);
Console.WriteLine(string2);