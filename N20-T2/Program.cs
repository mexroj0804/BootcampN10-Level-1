Console.Write("Massiv uzunligini kiriting: ");
var length = int.Parse(Console.ReadLine());

int[] lst = new int[length];
int min, max;

for (int i = 0; i < length; i++)
{
    Console.Write("Sonni kiriting: ");
    lst[i] = int.Parse(Console.ReadLine());
}

FindMinMax(out min, out max, lst);

static void FindMinMax(out int min, out int max, params int[] lst2)
{
    min = lst2.Min();
    max = lst2.Max();
}


foreach (int i in lst)
    Console.WriteLine(i);

Console.WriteLine($"Max: {max} -- Min: {min}");