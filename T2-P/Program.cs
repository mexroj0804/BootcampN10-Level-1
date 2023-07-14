using System.Text;

string str = "XAYBULLAYEV MEXROJ MANSURJONOVICH";
string[] lst;
lst = str.Split(" ");

for (int i = 0; i < lst.Length; i++)
{
    for (int j = 1; j < lst[i].Length; j++)
    {
        int int1 = lst[i][j] + 32;
        char lst1 = (char)int1;
        Console.WriteLine(lst1);
    }
};



Console.WriteLine(lst[0]);