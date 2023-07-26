Console.Write("Narxlarni kiriting: ");
var Narxlar = Console.ReadLine();


var split1 = Narxlar.Split(' ', '\n');
var lst  = new List<int>();

for  (int i = 0; i < split1.Length; i++)
{
    lst.Add(int.Parse(split1[i]));
}

for  (int i = 0; i < lst.Count; i++)
{
    Console.WriteLine(lst[i]);
}
for (int i = 0; i < lst.Count; i++) 
{
    var count = 0;
    var count2 = lst[i];
    for (int j = i + 1; j < lst.Count; j++)
    {
        if(count2 == lst[j])
        {
            count += 1;
            lst.Remove(lst[j]);
        }
    }
    Console.WriteLine(count);
}
for (int i = 0; i < lst.Count; i++)
{
    Console.WriteLine(lst[i]);
}