Console.Write("Enter surname: ");
string name = Console.ReadLine();

if (name.EndsWith("a") == false)
{
    Console.WriteLine("Male");
} else
{
    Console.WriteLine("Female");
}