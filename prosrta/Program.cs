var sanalar = new DateTime[5];
sanalar[0] = new DateTime(2023, 9, 23, 9, 0, 0);
sanalar[1] = new DateTime(2023, 8, 15, 11, 0, 0);
sanalar[2] = new DateTime(2023, 7, 30, 15, 0, 0);
sanalar[3] = new DateTime(2023, 9, 15, 9, 0, 0);
sanalar[4] = new DateTime(2023, 8, 10, 18, 0, 0);
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(sanalar[i]);
}
Array.Sort(sanalar);
Console.WriteLine();
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(sanalar[i]);
}