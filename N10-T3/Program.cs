var random = new Random();
int randomSon = random.Next(1, 10);

try
{
    while (true)
    {
        Console.Write("Ixtiyoriy son kiriting: ");
        var kiritilganSon = Console.ReadLine();
        if (int.TryParse(kiritilganSon, out var value))
        {
            if (value == randomSon)
            {
                Console.WriteLine("Congrats! You guessed it");
                break;
            } else
            {
                throw new ArgumentOutOfRangeException();
            }
        } else
        {
            throw new FormatException();
        }
        

    }
}
catch(ArgumentOutOfRangeException)
{
    Console.WriteLine("You couldn't guess it!");
}
catch (FormatException)
{
    Console.WriteLine("Not a number!");
}