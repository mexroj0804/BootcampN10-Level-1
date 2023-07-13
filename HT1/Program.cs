Console.Write("Passwordda harflar qatnashsinmi?: ");
string harf = Console.ReadLine();

Console.Write("Passwordda sonlar qatnashsinmi?: ");
string son = Console.ReadLine();

Console.Write("Passwordda simvollar qatnashsinmi?: ");
string simvol  = Console.ReadLine();

Console.Write("Password uzunligini kiriting: ");
int uzunligi = int.Parse(Console.ReadLine());

Random rd = new Random();

var s = rd.Next();
Console.WriteLine(s);