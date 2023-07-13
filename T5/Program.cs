Console.Write("Enter text: ");
string text  = Console.ReadLine();

Console.WriteLine(text);
Console.WriteLine(text.Count());
Console.WriteLine(text[0]);

Console.Write("Text turgan indexni kiriting: ");
int t1 = int.Parse(Console.ReadLine());

Console.Write("Va uning uzinligini kiriting: ");
int t2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Substring from index {t1} wizth length {t2}: {text.Substring(t1, t2)}");