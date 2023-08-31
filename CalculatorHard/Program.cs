Console.Write("Amalni kiriting: ");
string amal = Console.ReadLine();

Console.WriteLine(amal);

char[] lst = new char[amal.Length];

for (int i = 0; i < amal.Length; i++)
{
    lst[i] = amal[i];
}

for (int i = 0;i < lst.Length; i++)
{
    Console.WriteLine(lst[i]);
}